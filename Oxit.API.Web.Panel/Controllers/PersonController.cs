using Microsoft.AspNetCore.Mvc;
using Oxit.Common.Domain;
using Oxit.Common.ViewModels.Person;

namespace Oxit.API.Web.Panel.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]/")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService person;

        public PersonController(PersonService person)
        {
            this.person = person;
        }


        [HttpGet]
        public async Task<IActionResult> Get(Guid Id)
        {
            return Ok(person.Get<PersonGetViewModel>(Id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(person.GetAll<PersonGetAllViewModel>());
        }
        [HttpGet("{page}")]
        public async Task<IActionResult> GetAll(int page)
        {
            return Ok(person.GetAll<PersonGetAllViewModel>(page));
        }

    }
}