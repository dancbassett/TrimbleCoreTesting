using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Unit
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
            public string UN_BREF { get; set; }
            public string UN_UREF { get; set; }
            public string UN_NREF { get; set; }
            public string UN_VACT { get; set; }
            public string UN_OWN { get; set; }
            public string UN_CLASS { get; set; }
            public string UN_TENR { get; set; }
            public string UN_FURN { get; set; }
            public string UN_COND { get; set; }
            public string UN_NDAT { get; set; }
            public string UN_NAME { get; set; }
            public string UN_ADD1 { get; set; }
            public string UN_ADD2 { get; set; }
            public string UN_ADD3 { get; set; }
            public string UN_ADD4 { get; set; }
            public string UN_ADD5 { get; set; }
            public string UN_ADD6 { get; set; }
            public string UN_POST { get; set; }
            public string UN_TEL { get; set; }
            public string UN_TELX { get; set; }
            public string UN_FAX { get; set; }
            public string UN_CONT { get; set; }
            public string UN_LINT { get; set; }
            public string UN_LEXT { get; set; }
            public string UN_NINT { get; set; }
            public string UN_NEXT { get; set; }
            public string UN_IDECY { get; set; }
            public string UN_EDECY { get; set; }
            public int UN_GFA { get; set; }
            public string UN_NFA { get; set; }
            public string UN_UPRIX { get; set; }
            public string UN_VAL1 { get; set; }
            public string UN_VAL2 { get; set; }
            public string UN_VAL3 { get; set; }
            public string UN_VAL4 { get; set; }
            public string UN_VAL5 { get; set; }
            public string UN_VAREA { get; set; }
            public string UN_INSEE { get; set; }
            public string UN_USER1 { get; set; }
            public string UN_USER2 { get; set; }
            public string UN_USER3 { get; set; }
            public string UN_USER4 { get; set; }
            public string UN_USER5 { get; set; }
            public string UN_RAREA { get; set; }
            public string UN_RVAL { get; set; }
            public string UN_RENTV { get; set; }
            public string UN_AGENT { get; set; }
            public string UN_PTENT { get; set; }
            public string UN_NTNTS { get; set; }
            public string UN_NTDAT { get; set; }
            public string UN_UPDATE { get; set; }
            public string UN_UTIME { get; set; }
            public string UN_UUSER { get; set; }
            public string UN_NCPK { get; set; }
            public string UN_C1 { get; set; }
            public string UN_C2 { get; set; }
            public string UN_C3 { get; set; }
            public string UN_C4 { get; set; }
            public string UN_C5 { get; set; }
            public string UN_C6 { get; set; }
            public string UN_C7 { get; set; }
            public string UN_C8 { get; set; }
            public string UN_R1 { get; set; }
            public string UN_R2 { get; set; }
            public string UN_R3 { get; set; }
            public string UN_R4 { get; set; }
            public string UN_R5 { get; set; }
            public string UN_R6 { get; set; }
            public string UN_R7 { get; set; }
            public string UN_R8 { get; set; }
            public string UN_HIST { get; set; }
            public string UN_SOLD { get; set; }
            public string UN_VA { get; set; }
            public string UN_USER6 { get; set; }
            public string UN_NL { get; set; }
            public string UN_OBS1 { get; set; }
            public string UN_OBS2 { get; set; }
            public string UN_OBS3 { get; set; }
            public string UN_OBS4 { get; set; }
            public string UN_OBS5 { get; set; }
            public string UN_OBS6 { get; set; }
            public string UN_OBS7 { get; set; }
            public string UN_OBS8 { get; set; }
            public string UN_OBS9 { get; set; }
            public string UN_AUTH { get; set; }
            public string UN_WRVALUE1 { get; set; }
            public string UN_WRVALUE2 { get; set; }
            public string UN_WRVALUE { get; set; }
            public string UN_EMPLOYEES { get; set; }
            public string UN_TYPE { get; set; }
            public string UN_INREF { get; set; }
            public string UN_DEFAULTRATE { get; set; }
            public string UN_USERA1 { get; set; }
            public string UN_USERA2 { get; set; }
            public string UN_USERA3 { get; set; }
            public string UN_USERA4 { get; set; }
            public string UN_USERA5 { get; set; }
            public string UN_USERA6 { get; set; }
            public string UN_USERA7 { get; set; }
            public string UN_USERA8 { get; set; }
            public string UN_USERA9 { get; set; }
            public string UN_USERA10 { get; set; }
            public string UN_FREE { get; set; }
            public string UN_EMAIL { get; set; }
            public string UN_MAPNORTH { get; set; }
            public string UN_MAPEAST { get; set; }
            public string UN_LLIAB { get; set; }
            public string UN_AREAUOM { get; set; }
            public string UN_BUDIND { get; set; }
            public string S_UN_DESC { get; set; }
            public string UN_DESC { get; set; }
        }

        public class getUnits
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
            public string UN_UREF { get; set; }
        }


    }
}
