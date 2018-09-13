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
    public class ValuesController : ControllerBase
    {
        private IDemandeurBLL _demandeurBLL;

        public ValuesController(IDemandeurBLL demandeurBLL)
        {
            _demandeurBLL = demandeurBLL;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            var list = _demandeurBLL.GetDemandeur(id);
            return Ok(JsonConvert.SerializeObject(list));
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] JObject value)
        {
            return Ok(value);
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
