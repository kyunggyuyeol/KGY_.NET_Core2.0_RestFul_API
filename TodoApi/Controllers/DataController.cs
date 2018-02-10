using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.App_Code;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Data")]
    public class DataController : Controller
    {
        // GET: api/Data
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Data1", "Data2" };
        }

        // GET: api/Data/5
        [HttpGet("{id}", Name = "Get")]
        public Data Get(int id)
        {
            Data data = new Data();
            data.ID = 1;
            data.LastName = "GY";
            data.FirstName = "K";
            data.PayRate = 10.15;
            data.StartDate = DateTime.Parse("03/21/1990");
            data.EndDate = DateTime.Parse("03/21/2090");

            return data;
        }
         
        // POST: api/Data
        [HttpPost]
        public void Post([FromBody]Data value)
        {
            DataPer aa = new DataPer();
            long id = aa.saveData(value);
        }
        
        // PUT: api/Data/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
