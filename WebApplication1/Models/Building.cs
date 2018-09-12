using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Building
    {

        public class Rootobject
        {
            public Payload[] Payload { get; set; }
            public int Hits { get; set; }
        }

        public class Payload
        {
            public string RLS_GROUP { get; set; }
            public string PR_SNAM { get; set; }
            public string PR_OWN { get; set; }
            public string PR_REF { get; set; }
            public string PR_NAME { get; set; }
            public string PR_ADD1 { get; set; }
            public string PR_ADD2 { get; set; }
            public string PR_ADD3 { get; set; }
            public string PR_ADD4 { get; set; }
            public string PR_ADD5 { get; set; }
            public string PR_ADD6 { get; set; }
            public string PR_POST { get; set; }
            public string PR_TEL { get; set; }
            public string PR_TELX { get; set; }
            public string PR_FAX { get; set; }
            public string PR_CONT { get; set; }
            public string PR_NUNIT { get; set; }
            public string PR_INT { get; set; }
            public string PR_TENR { get; set; }
            public string PR_QDAY { get; set; }
            public string PR_CLSS { get; set; }
            public string PR_DRCT { get; set; }
            public string PR_AGENT { get; set; }
            public string PR_NOWN { get; set; }
            public string PR_BOWN { get; set; }
            public string PR_SOL { get; set; }
            public string PR_HSTT { get; set; }
            public string PR_HEND { get; set; }
            public string PR_HAMT { get; set; }
            public string PR_PFREQ { get; set; }
            public string PR_NTENT { get; set; }
            public string PR_NFLR { get; set; }
            public string PR_GRA { get; set; }
            public string PR_WATER { get; set; }
            public string PR_RATVAL { get; set; }
            public string PR_RTCT { get; set; }
            public string PR_SCHG { get; set; }
            public string PR_OCHG { get; set; }
            public string PR_GFA { get; set; }
            public string PR_ZONEA { get; set; }
            public string PR_ZONEB { get; set; }
            public string PR_ZONEC { get; set; }
            public string PR_UPDATE { get; set; }
            public string PR_UTIME { get; set; }
            public string PR_UUSER { get; set; }
            public string PR_HIST { get; set; }
            public string PR_TAXYN { get; set; }
            public string PR_TAX { get; set; }
            public string PR_START { get; set; }
            public string PR_END { get; set; }
            public string PR_FREQ { get; set; }
            public string PR_QTR { get; set; }
            public string PR_NDUE { get; set; }
            public string PR_TAXRUN { get; set; }
            public string PR_OUTLET { get; set; }
            public string PR_INLET { get; set; }
            public string PR_VAL { get; set; }
            public string PR_CST { get; set; }
            public string PR_FRWA { get; set; }
            public string PR_FRWB { get; set; }
            public string PR_PRINT { get; set; }
            public string PR_NL { get; set; }
            public string PR_CURRS { get; set; }
            public string PR_NEXTS { get; set; }
            public string PR_VAT { get; set; }
            public string PR_USER { get; set; }
            public string PR_VQDAY { get; set; }
            public string PR_OBS1 { get; set; }
            public string PR_TYPE { get; set; }
            public string PR_VATDATE { get; set; }
            public string PR_FUTHER { get; set; }
            public string PR_RESTEN { get; set; }
            public string PR_CAPGOODS { get; set; }
            public string PR_INSEE { get; set; }
            public string PR_CURR { get; set; }
            public string PR_AQDATE { get; set; }
            public string PR_USER1 { get; set; }
            public string PR_USER2 { get; set; }
            public string PR_USER3 { get; set; }
            public string PR_USER4 { get; set; }
            public string PR_USER5 { get; set; }
            public string PR_USER6 { get; set; }
            public string PR_USER7 { get; set; }
            public string PR_USER8 { get; set; }
            public string PR_USER9 { get; set; }
            public string PR_USER10 { get; set; }
            public string PR_OBS2 { get; set; }
            public string PR_OBS3 { get; set; }
            public string PR_OBS4 { get; set; }
            public string PR_OBS5 { get; set; }
            public string PR_OBS6 { get; set; }
            public string PR_OBS7 { get; set; }
            public string PR_OBS8 { get; set; }
            public string PR_OBS9 { get; set; }
            public string PR_SOLD { get; set; }
            public string PR_DATESOLD { get; set; }
            public string PR_LAND { get; set; }
            public string PR_LANDUM { get; set; }
            public string PR_FREE { get; set; }
            public string PR_ID { get; set; }
            public string PR_BTYP { get; set; }
            public string PR_LEAS { get; set; }
            public string PR_RENT { get; set; }
            public string PR_USUM { get; set; }
            public string PR_FBUI { get; set; }
            public string PR_DREN { get; set; }
            public string PR_USRC { get; set; }
            public string PR_RSRC { get; set; }
            public string PR_LSRC { get; set; }
            public string PR_ELSR { get; set; }
            public string PR_EGRS { get; set; }
            public string PR_PROR { get; set; }
            public string PR_BSTA { get; set; }
            public string PR_LNAM { get; set; }
            public string PR_SITE { get; set; }
            public string PR_REGION { get; set; }
            public string PR_DESC { get; set; }
        }

        public class getProperties
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
            public string PR_ID { get; set; }
        }









        public class saveProp
        {


            public class cProperty
            {
                public string sessionID { get; set; }
                public string Component { get; set; }
                public string Operation { get; set; }
                public string PV_TOPIC { get; set; }
                public string PV_PROCESSID { get; set; }
                public string PV_LANGUAGE { get; set; }
                public string PV_PURPOSE { get; set; }
           //     public TL TL { get; set; }
                public List<PV_DATA_LIST> PV_DATA_LIST { get; set; }
                public PV_EXTRA PV_EXTRA { get; set; }

            }

            public class PV_DATA_LIST
            {

                public List<PROP> PROP { get; set; }
            }

            public class PROP
            {
                public string STATE { get; set; }
                public string CRC { get; set; }

                public TL[] TLS { get; set; }

                // public List<FieldDetails> fieldList { get; set; }
            }

            public class PV_EXTRA
            {
                public string COMMIT { get; set; }
            }



            public class FieldDetails
            {
                public string FIELD { get; set; }
                public string BEFORE { get; set; }
                public string AFTER { get; set; }

            }



            public class TL
            {
                public string TLCRG_TREF { get; set; }
                public string TLCRG_LREF { get; set; }
                public string TLCRG_CTYPE { get; set; }
                public string TLCRG_SEQ { get; set; }
            }





        }




    }
}
