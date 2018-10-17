using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class FMContact
    {
        public class GetFMContact
        {

            public class Rootobject
            {
                public string Status { get; set; }
                public PV_OUTPUT[] PV_OUTPUT { get; set; }
                public Messages messages { get; set; }
            }

            public class Messages
            {
            }

            public class PV_OUTPUT
            {
                public Payload[] Payload { get; set; }
            }

            public class Payload
            {
                public string forName { get; set; }
                public string forPhone { get; set; }
                public string forEmail { get; set; }
                public string propertyId { get; set; }
                public string property { get; set; }
                public string cd_obs1 { get; set; }
                public string cd_obs3 { get; set; }
                public string cd_obs5 { get; set; }
                public string unitsL { get; set; }
                public string unitId { get; set; }
                public string unit { get; set; }
            }




            public class getFMCont
            {
                public string sessionID { get; set; }
                public string Component { get; set; }
                public string Operation { get; set; }
                public PV_PAYLOAD[] PV_PAYLOAD { get; set; }
            }

            public class PV_PAYLOAD
            {
                public string forId { get; set; }
            }



        }

        public class SetFMContact
        {

            public class saveContact
            {
                public string sessionID { get; set; }
                public string Component { get; set; }
                public string Operation { get; set; }
                public string PV_CONTACTREF { get; set; }
                public string PV_FULLNAME { get; set; }
                public string PV_EMAIL { get; set; }
                public string PV_VIP { get; set; }
                public string PV_PHONENUMBER { get; set; }
                public string PV_MOBILENUMBER { get; set; }
                public string PV_FAX { get; set; }
                public string PV_ADDRESS1 { get; set; }
                public string PV_ADDRESS2 { get; set; }
                public string PV_ADDRESS3 { get; set; }
                public string PV_ADDRESS4 { get; set; }
                public string PV_ADDRESS5 { get; set; }
                public string PV_ADDRESS6 { get; set; }
                public string PV_POSTCODE { get; set; }
                public string PV_EXPIREDATE { get; set; }
                public string PV_CNA_OBS1 { get; set; }
                public string PV_CNA_OBS2 { get; set; }
                public string PV_CNA_OBS3 { get; set; }
                public string PV_CNA_OBS4 { get; set; }
                public string PV_CNA_OBS5 { get; set; }
                public string PV_CNA_OBS6 { get; set; }
                public string PV_DESCRIPTION { get; set; }
                public string PV_EXTRA_IN { get; set; }
            }


        }


    }
}
