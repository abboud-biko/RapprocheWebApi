using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapprocheWebApi.BLL.Services;

namespace RapprocheWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RapprochementsController : ControllerBase
    {
        private IRapprochementBLL _rapprochementBLL;

        public RapprochementsController(IRapprochementBLL rapprochementBLL)
        {
            _rapprochementBLL = rapprochementBLL;
        }

        // GET api/values
        [HttpGet]
        public void Get()
        {
        }

        // GET api/values/datetime
        [HttpGet("{date}")]
        public IActionResult Get(DateTime date)
        {
            var list = _rapprochementBLL.GetRapprochementsByDate(date);
            return Ok(JsonConvert.SerializeObject(list));
        }
        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] JObject value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
