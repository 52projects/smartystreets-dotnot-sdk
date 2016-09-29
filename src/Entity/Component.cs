using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartyStreets.Api.Entity {
    [DataContract(Name = "components")]
    public class Component {
        [DataMember(Name = "urbanization")]
        public string Urbanization { get; set; }

        [DataMember(Name = "primary_number")]
        public string PrimaryNumber { get; set; }

        [DataMember(Name = "street_name")]
        public string StreetName { get; set; }

        [DataMember(Name = "street_predirection")]
        public string StreetPredirection { get; set; }

        [DataMember(Name = "street_postdirection")]
        public string StreetPostdirection { get; set; }

        [DataMember(Name = "street_suffix")]
        public string StreetSuffix { get; set; }

        [DataMember(Name = "secondary_number")]
        public string SecondaryNumber { get; set; }

        [DataMember(Name = "secondary_designator")]
        public string SecondaryDesignator { get; set; }

        [DataMember(Name = "extra_secondary_number")]
        public string ExtraSecondaryNumber { get; set; }

        [DataMember(Name = "extra_secondary_designator")]
        public string ExtraSecondaryDesignator { get; set; }

        [DataMember(Name = "pmb_designator")]
        public string PMBDesignator { get; set; }

        [DataMember(Name = "pmb_number")]
        public string PMBNumber { get; set; }

        [DataMember(Name = "city_name")]
        public string CityName { get; set; }

        [DataMember(Name = "default_city_name")]
        public string DefaultCityName { get; set; }

        [DataMember(Name = "state_abbreviation")]
        public string StateAbbreviation { get; set; }

        [DataMember(Name = "zipcode")]
        public string Zipcode { get; set; }

        [DataMember(Name = "plus4_code")]
        public string Plus4Code { get; set; }

        [DataMember(Name = "delivery_point")]
        public string DeliveryPoint { get; set; }

        [DataMember(Name = "delivery_point_check_digit")]
        public string DeliveryPointCheckDigit { get; set; }
    }
}
