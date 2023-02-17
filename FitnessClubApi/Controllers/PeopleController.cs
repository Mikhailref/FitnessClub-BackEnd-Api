using FitnessClubApi.Interfaces;
using FitnessClubApi.Utilites;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<IPerson> Get()
        {
            //return new string[] { "value1", "value2" };
            return Programm.ReturnListOfPeople();
            
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public IPerson Get(int id)
        {
            return Programm.ReturnPerson();
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
