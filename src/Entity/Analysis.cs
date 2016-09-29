using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartyStreets.Api.Entity {
    [DataContract(Name = "analysis")]
    public class Analysis {
        [DataMember(Name = "dpv_match_code")]
        public string DPVMatchCode { get; set; }

        [DataMember(Name = "dpv_footnotes")]
        public string DPVFootnotes { get; set; }

        [DataMember(Name = "dpv_cmra")]
        public string DpvCmra { get; set; }

        [DataMember(Name = "dpv_vacant")]
        public string DpvVacant { get; set; }

        [DataMember(Name = "active")]
        public string Active { get; set; }

        [DataMember(Name = "ews_match")]
        public string EwsMatch { get; set; }

        [DataMember(Name = "lacslink_code")]
        public string LACSLinkCode { get; set; }

        [DataMember(Name = "lacslink_indicator")]
        public string LACSLinkIndicator { get; set; }

        [DataMember(Name = "suitelink_match")]
        public string SuitelinkMatch { get; set; }
    }
}
