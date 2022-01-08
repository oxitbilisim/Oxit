using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MainController : ControllerBase
    {
        private readonly appDbContext appDbContext;
        private readonly TeknoparkContext teknoparkContext;

        public MainController(
            appDbContext appDbContext,
            TeknoparkContext teknoparkContext
            )
        {
            this.appDbContext = appDbContext;
            this.teknoparkContext = teknoparkContext;
        }

        [HttpGet]
        public async Task<IActionResult> HealthCheck()
        {
            List<string> messages = new List<string>();


            try
            {
                var ss = appDbContext.Database.GetDbConnection();

                messages.Add(appDbContext.Database.CanConnect() ? "Postgre: baglandi" : "Postgre: baglanmadi");
                messages.Add(teknoparkContext.Database.CanConnect() ? "teknopark: baglandi" : "teknopark: baglanmadi");



                return Ok(messages);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }


        }
    }
}
