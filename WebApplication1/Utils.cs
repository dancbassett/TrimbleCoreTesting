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
using System.Collections;
using TestAPI.Models;
using System.Data.SqlClient;
using System.Data;

namespace TestAPI
{
  

    public class Utils
    {
        public string getProp(string id)
        {
            string session_id = login();

            TestAPI.Models.Building.PROFILE prf = new TestAPI.Models.Building.PROFILE();
            prf.PR_SNAM = id.ToString();

            TestAPI.Models.Building.getProperties lgo = new TestAPI.Models.Building.getProperties();
            List<TestAPI.Models.Building.PROFILE> propLst = new List<TestAPI.Models.Building.PROFILE>();

            if (id != "0")
            {
                propLst.Add(prf);
            }            else { }
            
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
            
            
            /** First try, not working 
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
                       


            //    var sp = SaveProp.FromJson("");

         QUICKTYPE
                        TestAPI.Models.Quicktype.SaveProp prop = new TestAPI.Models.Quicktype.SaveProp();

                             prop.SessionId = session_id;
                             prop.Component = "BSDBCOREAPI";
                             prop.Operation = "PROCESS";
                             prop.PvTopic = "SPDBMPROP";
                             prop.PvPurpose = "PUT";
                             prop.PvProcessid = "";
                             prop.PvLanguage = "";

                        TestAPI.Models.Quicktype.PvDataListProp pvDataListProp = new TestAPI.Models.Quicktype.PvDataListProp();

                        TestAPI.Models.Quicktype.FieldDetail[] fieldDetails = new Models.Quicktype.FieldDetail[100];

                        TestAPI.Models.Quicktype.FieldDetail fieldDetail = new TestAPI.Models.Quicktype.FieldDetail();
                        fieldDetail.Field = "PR_SNAM";
                        fieldDetail.Before = "";
                        fieldDetail.After = "Test12345";

                        fieldDetails[0] = fieldDetail;


                        TestAPI.Models.Quicktype.TProp tProp = new TestAPI.Models.Quicktype.TProp();
                        tProp.TlcrgCtype = "R";
                        tProp.TlcrgLref = "";
                        tProp.TlcrgSeq = "";
                        tProp.TlcrgTref = "";

                        TestAPI.Models.Quicktype.PropPropUnion propPropUnion = new TestAPI.Models.Quicktype.PropPropUnion();

                             propPropUnion.TProp = tProp;
                        propPropUnion.FieldDetailArray = fieldDetails;

                             TestAPI.Models.Quicktype.PropUpdateDetails propUpdateDetails = new TestAPI.Models.Quicktype.PropUpdateDetails();
                        propUpdateDetails.Crc = "";
                        propUpdateDetails.State = "new";
                             pvDataListProp.PropUpdateDetails = propUpdateDetails;

                        TestAPI.Models.Quicktype.PropPropUnion[] propPropUnions = new TestAPI.Models.Quicktype.PropPropUnion[100];

                        propPropUnions[0] = propPropUnion;

                        pvDataListProp.AnythingArray = propPropUnions;


                        TestAPI.Models.Quicktype.PvDataList[] pvDataLists = new TestAPI.Models.Quicktype.PvDataList[100];

                        TestAPI.Models.Quicktype.PvDataList pvDataList = new Models.Quicktype.PvDataList();

                        TestAPI.Models.Quicktype.PvDataListProp[][] pvDataListProps = new Models.Quicktype.PvDataListProp[100][];

                        TestAPI.Models.Quicktype.PvDataListProp[] pvDataListPropProp = new Models.Quicktype.PvDataListProp[100];

                        pvDataListPropProp[0] = pvDataListProp;


                        pvDataListProps[0] = pvDataListPropProp;


                        pvDataList.Prop = pvDataListProps;
                        pvDataLists[0] = pvDataList;

                        prop.PvDataList = pvDataLists;
                         var jsonscrpt = JsonConvert.SerializeObject(prop);
                  */

            // ANOTHER TRY, not working
            Building.saveProp.cProperty prop = new Building.saveProp.cProperty();
            prop.sessionID = session_id;
            prop.Component = "BSDBCOREAPI";
            prop.Operation = "PROCESS";
            prop.PV_TOPIC = "SPDBMPROP";
            prop.PV_PURPOSE = "PUT";
            prop.PV_PROCESSID = "";
            prop.PV_LANGUAGE = "";

            Building.saveProp.PROP prp = new Building.saveProp.PROP();
            prp.CRC = "";
            prp.STATE = "new";
            Building.saveProp.TL tL = new Building.saveProp.TL();
            tL.TLCRG_CTYPE = "R";
            tL.TLCRG_LREF = "";
            tL.TLCRG_SEQ = "";
                tL.TLCRG_TREF = "";

            ArrayList PROP = new ArrayList();
            ArrayList prpDets = new ArrayList();
            prpDets.Add(tL);

            Building.saveProp.FieldDetails fd = new Building.saveProp.FieldDetails();
            fd.AFTER = "Dan Test 12312";
            fd.BEFORE = "";
            fd.FIELD = "PR_SNAM";
            prpDets.Add(fd);

            //    Building.saveProp.TL[] tLs = new Building.saveProp.TL[] { tL };
            prp.prpDets = prpDets;

          //  prp.TLS = tLs;

            List<Building.saveProp.PROP> props = new List<Building.saveProp.PROP>();


            Building.saveProp.PV_DATA_LIST pV_DATA_LIST = new Building.saveProp.PV_DATA_LIST();

            props.Add(prp);

            pV_DATA_LIST.PROP = PROP;
            pV_DATA_LIST.PROP.Add(prp);

            prop.PV_DATA_LIST = pV_DATA_LIST;
    

            /** Using RAW JSON, not ideal **/
            /*
            string JSON = "";
            JSON += "{\"sessionID\":\"" + session_id + "\",";
            JSON += "\"Component\": \"BSDBCOREAPI\",";
            JSON += "\"Operation\": \"PROCESS\",";
            JSON += "\"PV_TOPIC\": \"SPDBMPROP\",";
            JSON += " \"PV_PROCESSID\": \"\",";
            JSON += "\"PV_LANGUAGE\": \"\",";
            JSON += "\"PV_PURPOSE\": \"PUT\",";
            JSON += "\"PV_DATA_LIST\": [{";
            JSON += "\"PROP\": ";
            JSON += "[[[{\"TLCRG_TREF\": \"\"},{\"TLCRG_LREF\": \"\"},{\"TLCRG_CTYPE\": \"R\"},{\"TLCRG_SEQ\": \"\"}],";
            JSON += "{\"STATE\": \"new\"},{\"CRC\": \"\"},[";

            JSON += "[{\"FIELD\": \"PR_SNAM\"},{\"BEFORE\": \"\"},{\"AFTER\": \"test\"}],";
            JSON += "[{\"FIELD\": \"PR_ADD1\"},{\"BEFORE\": \"\"},{\"AFTER\": \"test\"}],";

            JSON += "[{\"FIELD\": \"PR_VAL\"},{\"BEFORE\": \"\"},{\"AFTER\": \"500\"}],";
            JSON += "[{\"FIELD\": \"PR_NAME\"},{\"BEFORE\": \"\"},{\"AFTER\": \"test\"}],";
            JSON += "[{\"FIELD\": \"PR_TYPE\"},{\"BEFORE\": \"\"},{\"AFTER\": \"Property\"}],";
            JSON += "[{\"FIELD\": \"PR_OWN\"},{\"BEFORE\": \"\"},{\"AFTER\": \"MT_CLIENT0\"}],";
            JSON += "[{\"FIELD\": \"PR_POST\"},{\"BEFORE\": \"\"},{\"AFTER\": \"test\"}],";


            JSON += "[{\"FIELD\": \"PR_REF\"},{\"BEFORE\": \"\"},{\"AFTER\": \"test\"}],";
            JSON += "[{\"FIELD\": \"PR_VAT\"},{\"BEFORE\": \"\"},{\"AFTER\": \"A\"}],";
            JSON += "[{\"FIELD\": \"PR_VATDATE\"},{\"BEFORE\": \"\"},{\"AFTER\": \"20320914\"}],";


            JSON += "[{\"FIELD\": \"PR_CLSS\"},{\"BEFORE\": \"\"},{\"AFTER\": \"APT\"}],";
            JSON += "[{\"FIELD\": \"PR_TENR\"},{\"BEFORE\": \"\"},{\"AFTER\": \"LEASED\"}],";

            JSON += "[{\"FIELD\": \"PR_ADD4\"},{\"BEFORE\": \"\"},{\"AFTER\": \"GE\"}],";
            JSON += "[{\"FIELD\": \"PR_ADD5\"},{\"BEFORE\": \"\"},{\"AFTER\": \"LONDON\"}],";
            JSON += "[{\"FIELD\": \"PR_LAND\"},{\"BEFORE\": \"\"},{\"AFTER\": \"1\"}],";

            JSON += "[{\"FIELD\": \"PR_DATESOLD\"},{\"BEFORE\": \"\"},{\"AFTER\": \"01-01-2017\"}],";
            JSON += "[{\"FIELD\": \"PR_AQDATE\"},{\"BEFORE\": \"\"},{\"AFTER\": \"01-01-2017\"}]";
            JSON += "]]]}],";
            JSON += " \"PV_EXTRA\": [{\"COMMIT\": \"T\"}]}";
            */
            
         //   var saveProp = TestAPI.Models.Quicktype.SaveProp.FromJson(JSON);

            string response1 = trimbleCall(prop, "SPDEDMHAPI.SVC?comp=/BSDBCOREAPI.PROCESS", "POST");

        //    string response = trimbleCallRAW(JSON, "SPDEDMHAPI.SVC?comp=/BSDBCOREAPI.PROCESS", "POST");
            //   jsonscrpt = JsonConvert.SerializeObject(prop);

            return "";
        }



        public string getUnit(string id)
        {

            string session_id = login();

            TestAPI.Models.Unit.PROFILE prf = new TestAPI.Models.Unit.PROFILE();
            prf.UN_UREF = id.ToString();

            TestAPI.Models.Unit.getUnits lgo = new TestAPI.Models.Unit.getUnits();
            List<TestAPI.Models.Unit.PROFILE> propLst = new List<TestAPI.Models.Unit.PROFILE>();

            if (id != "0")
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


        public string getOwner(string id)
        {

            string session_id = login();

            TestAPI.Models.Owner.PROFILE prf = new TestAPI.Models.Owner.PROFILE();
            prf.OW_REF = id.ToString();

            TestAPI.Models.Owner.getOwners lgo = new TestAPI.Models.Owner.getOwners();
            List<TestAPI.Models.Owner.PROFILE> propLst = new List<TestAPI.Models.Owner.PROFILE>();

            if (id != "0")
            {

                propLst.Add(prf);
            }
            else { }



            lgo.sessionID = session_id;
            lgo.FORMAT = "payload";
            lgo.GRIDID = "OWNER";
            lgo.FROM = 0;
            lgo.HITS = 100;
            lgo.VISIBLE = null;
            lgo.PROFILE = propLst;
            lgo.ORDERBY = "OW_NAME";


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



   //     string username = Configuration["username"];
    //            string password = Configuration["password"];

                TestAPI.Models.userLogin lgn = new TestAPI.Models.userLogin
                {
                    method = "login",
                    username = "camelot_api",
                    password = "Iamin18"
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


        public string getFMCont(string id)
        {

            string session_id = login();


            Models.FMContact.GetFMContact.PV_PAYLOAD[] pV_PAYLOADs = new FMContact.GetFMContact.PV_PAYLOAD[1];
            Models.FMContact.GetFMContact.PV_PAYLOAD pV_PAYLOAD = new FMContact.GetFMContact.PV_PAYLOAD();
            if (id.Length > 0)
            {
                pV_PAYLOAD.forId = id;
                pV_PAYLOADs[0] = pV_PAYLOAD;
            }
            Models.FMContact.GetFMContact.getFMCont getFMCont = new FMContact.GetFMContact.getFMCont();

            getFMCont.PV_PAYLOAD = pV_PAYLOADs;
            getFMCont.sessionID = session_id;
            getFMCont.Component = "BSFMAPI";
            getFMCont.Operation = "GETFORINFO";


            string response = trimbleCall(getFMCont, "SPDEDMHAPI.SVC?comp=/BSFMAPI.GETFORINFO", "POST");

            //   var jsonscrpt = JsonConvert.SerializeObject(lgo);
            logout(session_id);


            return response;
        }

        public string saveDoc(string id)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr = null;
            string photo = "";
            byte[] photoByte = new byte[0];
            string filename = "";

            try
            {
                conn.ConnectionString = "server=camws002.camelot.lan;integrated security=false;uid=crm_user;pwd=hellocrm;database=CAMELOT_VBT_LIVE;";
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "get_document_for_testing";
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    photoByte = (byte[])rdr["photo"];
                    filename = rdr["filename"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                rdr.Close();
                cmd.Dispose();
                conn.Dispose();
            }

            TestAPI.Models.Document.SetDocument.SaveDoc doc = new Document.SetDocument.SaveDoc();
            string response = "";
            string session_id = login();

            doc.sessionID = session_id;
            doc.Operation = "CHECK_IN";
            doc.Component = "BSDBMDOCMGT";
            doc.PV_ENTITY = "PROP";
            doc.PV_VARIATION = "Property";
            doc.PV_FK = id;
            doc.PV_FILENAME = filename;
            doc.PV_FILE_CONTENT = Convert.ToBase64String(photoByte);
            TestAPI.Models.Document.SetDocument.PV_EXTRA_IN pV_EXTRA_IN = new Document.SetDocument.PV_EXTRA_IN();
            TestAPI.Models.Document.SetDocument.PV_EXTRA_IN[] pV_EXTRA_INs = new TestAPI.Models.Document.SetDocument.PV_EXTRA_IN[1];
            pV_EXTRA_IN.ENCODING = "BASE64";
            pV_EXTRA_INs[0] = pV_EXTRA_IN;
            doc.PV_EXTRA_IN= pV_EXTRA_INs;


            try
            {
                response = trimbleCall(doc, "SPDEDMHAPI.SVC?comp=/BSDBMDOCMGT.CHECK_IN", "POST");
            }
            catch(Exception exp) { Console.Write(exp.Message); }
            logout(session_id);
            return response;
        }



        public string getDoc(string id)
        {

         /*   string session_id = login();

            TestAPI.Models.Document.GetDocument.GetDoc docCall = new Models.Document.GetDocument.GetDoc();

            docCall.sessionID = session_id;
            docCall.Component = "SPDBMATTACHMENT";
            //   getFMCont.Operation = "GETFORINFO";
            docCall.DOC_NUMBER = id;
            docCall.DOC_VERSION = "1";
            docCall.RESTYPE = "docmgmnt";


            string response = trimbleCall(docCall, "SPDBMATTACHMENT.THUMBNAIL?", "POST");

            //   var jsonscrpt = JsonConvert.SerializeObject(lgo);
            logout(session_id);

    */

            string session_id = login();

            TestAPI.Models.Document.GetDocument.GetDoc docCall = new Models.Document.GetDocument.GetDoc();

            docCall.sessionID = session_id;
            //docCall.Component = "SPDBMATTACHMENT";
            docCall.DOC_NUMBER = id;
            docCall.DOC_VERSION = "1";
            docCall.RESTYPE = "docmgmnt";


            string response = trimbleCall(docCall, "SPDBMATTACHMENT.URLDISPLAY?VIEW=1&COMP=SPDBMATTACHMENT&VIEW=1&MODE=GET", "POST");

            //   var jsonscrpt = JsonConvert.SerializeObject(lgo);
            logout(session_id);

            return response;
        }


        public string trimbleCallRAW(string JSON, string method, string postGet)
        {
            try
            {
                string webAddr = "https://mh-uat.trimble-app.uk:443/camelot_uat/wrd/run/" + method;
                string responseText;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "text/json; charset=utf-8";
                httpWebRequest.Method = postGet;
                httpWebRequest.Accept = "text/json";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(JSON);
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
                return null;
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
