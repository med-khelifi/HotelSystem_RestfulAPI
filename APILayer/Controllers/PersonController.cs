using BL.Services.MainServices;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IService<Person> _personService;
        public PersonController(IService<Person> service) 
        {
            _personService = service;
        }

        [HttpGet("GetAllPersons")]
        public async Task<IActionResult> GetAllPersons()
        {
            var persons = await _personService.GetAllAsync();
            return Ok(persons);
        }
    }
}
