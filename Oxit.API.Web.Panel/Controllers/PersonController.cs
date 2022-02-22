using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oxit.API.Shared;
using Oxit.Common.Domain;
using Oxit.Common.Models;
using Oxit.Common.ViewModels.Person;
using Oxit.Infrastructure;

namespace Oxit.API.Web.Panel.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]/")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService person;
        private readonly IMapper mapper;

        public PersonController(PersonService person, IMapper mapper)
        {
            this.person = person;
            this.mapper = mapper;
        }
        [HttpGet, Authorizer]
        public async Task<IActionResult> Get(Guid Id)
        {
            return Ok(person.Get<PersonGetViewModel>(Id));
        }
        [HttpGet, Authorizer(Permissions.General.All)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(person.GetAll<PersonGetAllViewModel>());
        }
        [HttpGet("{page}")]
        public async Task<IActionResult> GetAll(int page)
        {
            return Ok(person.GetAll<PersonGetAllViewModel>(page));
        }
        [HttpPost]
        public async Task<IActionResult> Post(PersonSaveViewModel model)
        {
            return Ok(person.Add(mapper.Map<Person>(model)));
        }
        [HttpPut]
        public async Task<IActionResult> Put(PersonSaveViewModel model)
        {
            return Ok(person.Update(mapper.Map<Person>(model)));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid Id)
        {
            return Ok(person.Delete(Id));
        }
    }
}