using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Document
    {

        public class GetDocument
        {

            public class GetDoc
            {
                public string sessionID { get; set; }
                public string RESTYPE { get; set; }
                public string DOC_NUMBER { get; set; }
                public string DOC_VERSION { get; set; }
             //   public string Component { get; set; }
            }


        }


        public class SetDocument
        {

            public class SaveDoc
            {
                public string sessionID { get; set; }
                public string Component { get; set; }
                public string Operation { get; set; }
                public string PV_ENTITY { get; set; }
                public string PV_VARIATION { get; set; }
                public string PV_FK { get; set; }
                public string PV_FILENAME { get; set; }
                public string PV_FILE_CONTENT { get; set; }
                public PV_EXTRA_IN[] PV_EXTRA_IN { get; set; }
            }

            public class PV_EXTRA_IN
            {
                public string ENCODING { get; set; }
            }

        }
    }
}
