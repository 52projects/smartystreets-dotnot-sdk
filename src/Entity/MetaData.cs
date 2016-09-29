using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartyStreets.Api.Entity {
    [DataContract(Name = "metadata")]
    public class MetaData {
        [DataMember(Name = "record_type")]
        public string RecordType { get; set; }

        [DataMember(Name = "zip_type")]
        public string ZipType { get; set; }

        [DataMember(Name = "county_fips")]
        public string CountyFips { get; set; }

        [DataMember(Name = "county_name")]
        public string CountyName { get; set; }

        [DataMember(Name = "congressional_district")]
        public string CongressionalDistrict { get; set; }

        [DataMember(Name = "building_default_indicator")]
        public string BuildingDefaultIndicator { get; set; }

        [DataMember(Name = "rdi")]
        public string RDI { get; set; }

        [DataMember(Name = "elot_sequence")]
        public string ElotSequence { get; set; }

        [DataMember(Name = "elot_sort")]
        public string ElotSort { get; set; }

        [DataMember(Name = "latitude")]
        public string Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public string Longitude { get; set; }

        [DataMember(Name = "precision")]
        public string Precision { get; set; }

        [DataMember(Name = "time_zone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "utc_offset")]
        public string UTCOffset { get; set; }

        [DataMember(Name = "dst")]
        public string DST { get; set; }
    }
}
