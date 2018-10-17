using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FMContactController : ControllerBase
    {
        // GET api/Buildings
        [HttpGet]
        public ActionResult<string> Get()
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";

           // Models.FMContact.GetFMContact.Rootobject fMContact = new Models.FMContact.GetFMContact.Rootobject();
            response = ut.getFMCont("");
          //  fMContact = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.FMContact.GetFMContact.Rootobject>(response);
            return  response ;
        }

    

        // GET api/Buildings/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<object>> Get(string id)
        {
            TestAPI.Utils ut = new TestAPI.Utils();
            string response = "";
            Models.FMContact.GetFMContact.Rootobject fMContact = new Models.FMContact.GetFMContact.Rootobject();
            response = ut.getFMCont(id);
            fMContact = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.FMContact.GetFMContact.Rootobject>(response);
            return new object[] { "Response", fMContact };
 
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