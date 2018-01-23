using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public List<Todo> Get(int id)
        {
            List<Todo> returnValue = new List<Todo>();
            returnValue.Add(new Todo() { Id = 1, Name = "a", IsComplete = true });
            returnValue.Add(new Todo() { Id = 2, Name = "B", IsComplete = false });
            returnValue.Add(new Todo() { Id = 3, Name = "C", IsComplete = true });
            returnValue.Add(new Todo() { Id = 4, Name = "D", IsComplete = false });
            returnValue.Add(new Todo() { Id = 5, Name = "E", IsComplete = true });

            return returnValue;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
