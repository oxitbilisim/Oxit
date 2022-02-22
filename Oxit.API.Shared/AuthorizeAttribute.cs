using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace Oxit.API.Shared
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizerAttribute : Attribute, IAuthorizationFilter
    {
        private string claim;
        public AuthorizerAttribute(string claim)
        {
            this.claim = claim;
        }
        public AuthorizerAttribute()
        {

        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Items["User"] != null)
            {
                var userid = context.HttpContext.Items["User"].ToString();
                var userManager = context.HttpContext.RequestServices.GetService<UserManager<IdentityUser>>();
                var user = userManager.FindByIdAsync(userid).Result;
                if (user != null)
                    if (string.IsNullOrEmpty(claim) || userManager.GetClaimsAsync(user).Result.Any(c => c.Value == claim))
                        return;

            }

            context.Result = new UnauthorizedResult();
        }
    }
}
