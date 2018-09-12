using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Owner
    {

        public class Rootobject
        {
            public Payload[] Payload { get; set; }
            public int Hits { get; set; }
        }

        public class Payload
        {
            public string U_VERSION { get; set; }
            public string RLS_GROUP { get; set; }
            public string OW_REF { get; set; }
            public string OW_NAME { get; set; }
            public string OW_SALUT { get; set; }
            public string OW_ADD1 { get; set; }
            public string OW_ADD2 { get; set; }
            public string OW_ADD3 { get; set; }
            public string OW_ADD4 { get; set; }
            public string OW_ADD5 { get; set; }
            public string OW_ADD6 { get; set; }
            public string OW_POST { get; set; }
            public string OW_TEL { get; set; }
            public string OW_TELX { get; set; }
            public string OW_FAX { get; set; }
            public string OW_CONT { get; set; }
            public string OW_SOL { get; set; }
            public string OW_AUD { get; set; }
            public string OW_EXTRA { get; set; }
            public string OW_HIST { get; set; }
            public string OW_JFP_FLAG { get; set; }
            public string OW_TAXYN { get; set; }
            public string OW_TAX { get; set; }
            public string OW_TFN { get; set; }
            public string OW_START { get; set; }
            public string OW_END { get; set; }
            public string OW_FREQ { get; set; }
            public string OW_QTR { get; set; }
            public string OW_NDUE { get; set; }
            public string OW_TAXRUN { get; set; }
            public string OW_VCOD { get; set; }
            public string OW_CURR { get; set; }
            public string OW_INSEE { get; set; }
            public string OW_PMIND { get; set; }
            public string OW_SIRET { get; set; }
            public string OW_RPER { get; set; }
            public string OW_NL { get; set; }
            public string OW_PORT { get; set; }
            public string OW_FREE { get; set; }
            public string OW_TYPE { get; set; }
            public string OW_CPAY { get; set; }
            public string OW_CPADD1 { get; set; }
            public string OW_CPADD2 { get; set; }
            public string OW_CPADD3 { get; set; }
            public string OW_CPADD4 { get; set; }
            public string OW_CPPOST { get; set; }
            public string OW_CPTEL1 { get; set; }
            public string OW_CPTEL2 { get; set; }
            public string OW_CPTEL3 { get; set; }
            public string OW_USER1 { get; set; }
            public string OW_USER2 { get; set; }
            public string OW_USER3 { get; set; }
            public string OW_USER4 { get; set; }
            public string OW_USER5 { get; set; }
            public string OW_USER6 { get; set; }
            public string OW_USER7 { get; set; }
            public string OW_USER8 { get; set; }
            public string OW_USER9 { get; set; }
            public string OW_USER10 { get; set; }
            public string OW_OBS1 { get; set; }
            public string OW_OBS2 { get; set; }
            public string OW_OBS3 { get; set; }
            public string OW_OBS4 { get; set; }
            public string OW_OBS5 { get; set; }
            public string OW_OBS6 { get; set; }
            public string OW_OBS7 { get; set; }
            public string OW_OBS8 { get; set; }
            public string OW_OBS9 { get; set; }
            public string OW_VATP { get; set; }
            public string OW_VATR { get; set; }
            public string OW_RICS { get; set; }
            public string OW_STAT { get; set; }
            public string OW_LSTDATE { get; set; }
            public string OW_VATDATE { get; set; }
            public string OW_VATPRODIND { get; set; }
            public string OW_FICO { get; set; }
            public string OW_FEEBILL { get; set; }
            public string OW_APAY { get; set; }
            public string OW_PARENT { get; set; }
            public string OW_FLOAT { get; set; }
            public string OW_YEDATE { get; set; }
            public string OW_M1 { get; set; }
            public string OW_BPIND { get; set; }
            public string OW_CASHACC { get; set; }
            public string OW_CASHACCGL { get; set; }
            public string S_OW_TEXT { get; set; }
            public string OW_TEXT { get; set; }
        }

        public class getOwners
        {
            public string sessionID { get; set; }
            public string FORMAT { get; set; }
            public string GRIDID { get; set; }
            public string GRIDVIEW { get; set; }
            public int FROM { get; set; }
            public int HITS { get; set; }
            public string[] VISIBLE { get; set; }
            public List<PROFILE> PROFILE { get; set; }
            public string ORDERBY { get; set; }
        }

        public class PROFILE
        {
            public string OW_REF { get; set; }
        }


    }
}
