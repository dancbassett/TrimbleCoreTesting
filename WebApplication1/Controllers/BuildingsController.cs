using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController  : ControllerBase
    {
        // GET api/Buildings
        [HttpGet]
        public ActionResult<string> Get()
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";
            Models.Building.Rootobject prop = new Models.Building.Rootobject();
            response = ut.getProp("0");

         //   prop = Newtonsoft.Json.JsonConvert.DeserializeObject<TestAPI.Models.Building.Rootobject>(response);
            return response ;
        }

        /*
                // GET api/Buildings
        [HttpGet]
        public ActionResult<IEnumerable<object>> Get()
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";
            Models.Building.Rootobject prop = new Models.Building.Rootobject();
            response = ut.getProp("0");

            prop = Newtonsoft.Json.JsonConvert.DeserializeObject<TestAPI.Models.Building.Rootobject>(response);
            return new object[] { prop };
        } 
             * */

        // GET api/Buildings/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";


        //    response = ut.getProp(id); PUT BACK IN

            response = ut.saveProp();

       //     Models.Building.Rootobject prop = new Models.Building.Rootobject();
       //     prop = Newtonsoft.Json.JsonConvert.DeserializeObject<TestAPI.Models.Building.Rootobject>(response);
            return  response ;
        }





        // POST api/Buildings
        [HttpPost]
        public void Post([FromBody] string value)
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";

            response = ut.saveProp();
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
