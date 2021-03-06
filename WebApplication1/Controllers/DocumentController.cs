﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        // GET api/Buildings
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";

            response = ut.getDoc("");

            return new string[] { "Response", response };
        }

        /*
        // GET api/Buildings/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(string id)
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";


            response = ut.getUnit(Int32.Parse(id));

            return new string[] { response };
        }
*/


        // GET api/Buildings/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";
            


            response = ut.saveDoc(id);
         //   Models.Unit.Rootobject unit = new Models.Unit.Rootobject();
          //  unit = Newtonsoft.Json.JsonConvert.DeserializeObject<TestAPI.Models.Unit.Rootobject>(response);
            return  response ;
        }




        // POST api/Buildings
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Buildings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Buildings/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}