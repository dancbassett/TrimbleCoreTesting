using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Web.Script.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
//using Microsoft.AspNet.Mvc.ModelBinding;
using Newtonsoft.Json;

using TestAPI.Models;

namespace TestAPI
{
    public class Utils
    {
        public string getProp(int id)
        {

            string session_id = login();

            TestAPI.Models.Building.PROFILE prf = new TestAPI.Models.Building.PROFILE();
            prf.PR_ID = id.ToString();

            TestAPI.Models.Building.getProperties lgo = new TestAPI.Models.Building.getProperties();
            List<TestAPI.Models.Building.PROFILE> propLst = new List<TestAPI.Models.Building.PROFILE>();

            if (id != 0)
            {

                propLst.Add(prf);
            }
            else { }
            


            lgo.sessionID = session_id;
            lgo.FORMAT = "payload";
            lgo.GRIDID = "PROP";
            lgo.FROM = 0;
            lgo.HITS = 100;
            lgo.VISIBLE = null;
            lgo.PROFILE = propLst;
            lgo.ORDERBY = "PR_DATESOLD";


            string response = trimbleCall(lgo, "SPDEDMHAPI.GRIDGET", "POST");

            //   var jsonscrpt = JsonConvert.SerializeObject(lgo);
            logout(session_id);


            return response;
        }

        public string saveProp ()
        {
           string session_id = "";
            session_id = login();
            /*
                       Models.Building.saveProperty prop = new Models.Building.saveProperty();

                       prop.sessionID = session_id;
                       prop.Component = "BSDBCOREAPI";
                       prop.Operation = "PROCESS";
                       prop.PV_TOPIC = "SPDBMPROP";
                       prop.PV_PURPOSE = "PUT";
                       prop.PV_PROCESSID = "";

                       prop.PV_LANGUAGE = "";

                       Models.Building.PV_EXTRA pV_EXTRAs = new Models.Building.PV_EXTRA()
                       {
                           COMMIT = "T"
                       };
                       prop.PV_EXTRA = pV_EXTRAs;

                       Models.Building.PROP prp = new Models.Building.PROP();
                       prp.CRC = "";
                       prp.STATE = "new";

                       prp.fieldList = new List<Models.Building.FieldDetails>();

                       Models.Building.FieldDetails fd = new Models.Building.FieldDetails();
                       fd.FIELD = "PR_NAME";
                       fd.BEFORE = "";
                       fd.AFTER = "Test 1234";

                       prp.fieldList.Add(fd);

                       Models.Building.PV_DATA_LIST pvd = new Models.Building.PV_DATA_LIST();
                       pvd.PROP = new List<Models.Building.PROP>();
                       pvd.PROP.Add(prp);

                       prop.PV_DATA_LIST = new List<Models.Building.PV_DATA_LIST>();
                       prop.PV_DATA_LIST.Add(pvd);

                       var jsonscrpt = JsonConvert.SerializeObject(prop);
                       */


            //    var sp = SaveProp.FromJson("");

            // sp.

            /*     SaveProp prop = new SaveProp();

                 prop.SessionId = session_id;
                 prop.Component = "BSDBCOREAPI";
                 prop.Operation = "PROCESS";
                 prop.PvTopic = "SPDBMPROP";
                 prop.PvPurpose = "PUT";
                 prop.PvProcessid = "";
                 prop.PvLanguage = "";

                 Models.PvDataListProp pvDataListProp = new PvDataListProp();

                 PurpleProp[] purpleProps ;

                 Models.PurpleProp purpleProp = new PurpleProp();
                 purpleProp.Field = "PR_SNAM";
                 purpleProp.Before = "";
                 purpleProp.After = "Test12345";


                 Models.FluffyProp fluffyProp = new FluffyProp();
                 fluffyProp.TlcrgCtype = "R";
                 fluffyProp.TlcrgLref = "";
                 fluffyProp.TlcrgSeq = "";
                 fluffyProp.TlcrgTref = "";

                 Models.PropPropUnion propPropUnion = new PropPropUnion();

                 propPropUnion.FluffyProp = fluffyProp;
                 propPropUnion.PurplePropArray

                 Models.TentacledProp tentacledProp = new TentacledProp();
                 tentacledProp.Crc = "";
                 tentacledProp.State = "new";

                 pvDataListProp.TentacledProp = tentacledProp;
                 //pvDataListProp.AnythingArray = propPropUnion[];

                 Models.PvDataList pvDataList = new PvDataList();
               //  pvDataList.

             var jsonscrpt = JsonConvert.SerializeObject(prop);
             */
            Building.saveProp.cProperty prop = new Building.saveProp.cProperty();
            prop.sessionID = session_id;
            prop.Component = "BSDBCOREAPI";
            prop.Operation = "PROCESS";
            prop.PV_TOPIC = "SPDBMPROP";
            prop.PV_PURPOSE = "PUT";
            prop.PV_PROCESSID = "";
            prop.PV_LANGUAGE = "";

            Building.saveProp.PROP prp = new Building.saveProp.PROP();

            Building.saveProp.TL tL = new Building.saveProp.TL();
            tL.TLCRG_CTYPE = "R";
            tL.TLCRG_LREF = "";
            tL.TLCRG_SEQ = "";
            tL.TLCRG_TREF = "";

            Building.saveProp.TL[] tLs = new Building.saveProp.TL[] { tL };
            prp.TLS = tLs;

            List<Building.saveProp.PROP> props = new List<Building.saveProp.PROP>();


            Building.saveProp.PV_DATA_LIST pV_DATA_LIST = new Building.saveProp.PV_DATA_LIST();

            props.Add(prp);

            pV_DATA_LIST.PROP = props;

            var jsonscrpt = JsonConvert.SerializeObject(prop);

            return "";
        }



        public string getUnit(int id)
        {

            string session_id = login();

            TestAPI.Models.Unit.PROFILE prf = new TestAPI.Models.Unit.PROFILE();
            prf.PR_ID = id.ToString();

            TestAPI.Models.Unit.getUnits lgo = new TestAPI.Models.Unit.getUnits();
            List<TestAPI.Models.Unit.PROFILE> propLst = new List<TestAPI.Models.Unit.PROFILE>();

            if (id != 0)
            {

                propLst.Add(prf);
            }
            else { }



            lgo.sessionID = session_id;
            lgo.FORMAT = "payload";
            lgo.GRIDID = "UNIT";
            lgo.FROM = 0;
            lgo.HITS = 100;
            lgo.VISIBLE = null;
            lgo.PROFILE = propLst;
            lgo.ORDERBY = "UN_NAME";


            string response = trimbleCall(lgo, "SPDEDMHAPI.GRIDGET", "POST");

            //   var jsonscrpt = JsonConvert.SerializeObject(lgo);
            logout(session_id);


            return response;
        }














        public string login()
        {

            TestAPI.Models.LoginCamelot lgnOK = new TestAPI.Models.LoginCamelot();

            try
            {
                string webAddr = "https://mh-uat.trimble-app.uk:443/camelot_uat/wrd/run/SPDEDJSONSERVICE.LOGIN";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "text/json; charset=utf-8";
                httpWebRequest.Method = "POST";
                httpWebRequest.Accept = "text/json";



                TestAPI.Models.userLogin lgn = new TestAPI.Models.userLogin
                {
                    method = "login",
                    username = "daniel.colchest",
                    password = "HSEfUh2Y3TPj"
                };
                //   var jsonscrpt = new JavaScriptSerializer().Serialize(lgn);

                var jsonscrpt = JsonConvert.SerializeObject(lgn);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    streamWriter.Write(jsonscrpt);

                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);


                    try
                    {
                        lgnOK = Newtonsoft.Json.JsonConvert.DeserializeObject<TestAPI.Models.LoginCamelot>(responseText);
                    }
                    catch (Exception exc) { }


                }
                return lgnOK.sessionID;

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void logout(string session_id)
        {
            try
            {
                string webAddr = "https://mh-uat.trimble-app.uk:443/camelot_uat/wrd/run/SPDEDJSONSERVICE.LOGOUT";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "text/json; charset=utf-8";
                httpWebRequest.Method = "POST";
                httpWebRequest.Accept = "text/json";


                TestAPI.Models.userLogout lgo = new TestAPI.Models.userLogout
                {
                    method = "logout",
                    sessionID = session_id

                };
                var jsonscrpt = JsonConvert.SerializeObject(lgo);


                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    streamWriter.Write(jsonscrpt);

                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        public string trimbleCall(object jsonObj, string method, string postGet)
        {
            try
            {
                string webAddr = "https://mh-uat.trimble-app.uk:443/camelot_uat/wrd/run/" + method;
                string responseText = "";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "text/json; charset=utf-8";
                httpWebRequest.Method = postGet;
                httpWebRequest.Accept = "text/json";

  
                var jsonscrpt = JsonConvert.SerializeObject(jsonObj);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    streamWriter.Write(jsonscrpt);

                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                     responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);


                }

                return responseText;

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return "Error";
            }
        }


    }
}
