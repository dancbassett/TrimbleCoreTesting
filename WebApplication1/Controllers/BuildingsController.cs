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
    public class BuildingsController : ControllerBase
    {
        // GET api/Buildings
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";

            response = ut.getProp(0);

            return new string[] {"Response", response };
        }

        /*     
             // GET api/Buildings/5
             [HttpGet("{id}")]
             public ActionResult<IEnumerable<string>> Get(string id)
             {
                 TestAPI.Utils ut = new TestAPI.Utils();
                 string response = "";


                 response = ut.getProp(Int32.Parse(id));

                 return new string[] { response };
             }

         */

        // GET api/Buildings/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<object>> Get(string id)
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";


            response = ut.getProp(Int32.Parse(id));
            Models.Building.Rootobject prop = new Models.Building.Rootobject();
            prop = Newtonsoft.Json.JsonConvert.DeserializeObject<TestAPI.Models.Building.Rootobject>(response);
            return new object[] { prop };
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
