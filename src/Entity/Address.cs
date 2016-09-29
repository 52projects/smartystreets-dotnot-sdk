using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartyStreets.Api.Entity {
    [DataContract]
    public class Address {
        [DataMember(Name = "input_id")]
        public string InputID { get; set; }

        [DataMember(Name = "input_index")]
        public int InputIndex { get; set; }

        [DataMember(Name = "candidate_index")]
        public int CandidateIndex { get; set; }

        [DataMember(Name = "addressee")]
        public string Addressee { get; set; }

        [DataMember(Name = "delivery_line_1")]
        public string DeliveryLine1 { get; set; }

        [DataMember(Name = "delivery_line_2")]
        public string DeliveryLine2 { get; set; }

        [DataMember(Name = "last_line")]
        public string LastLine { get; set; }

        [DataMember(Name = "delivery_point_barcode")]
        public string DeliveryPointBarcode { get; set; }

        [DataMember(Name = "components")]
        public Component Components { get; set; }

        [DataMember(Name = "metadata")]
        public MetaData MetaData { get; set; }

        [DataMember(Name = "analysis")]
        public Analysis Analysis { get; set; }

        //public FellowshipOne.Api.People.Model.Address ConvertToF1Address() {
        //    var address = new FellowshipOne.Api.People.Model.Address();
        //    var line1 = new System.Text.StringBuilder();
        //    var line2 = new System.Text.StringBuilder();

        //    if (!string.IsNullOrEmpty(this.Components.PrimaryNumber)) {
        //        line1.Append(this.Components.PrimaryNumber + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StreetPredirection)) {
        //        line1.Append(this.Components.StreetPredirection + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StreetName)) {
        //        line1.Append(this.Components.StreetName + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StreetSuffix)) {
        //        line1.Append(this.Components.StreetSuffix + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.SecondaryDesignator)) {
        //        line2.Append(this.Components.SecondaryDesignator + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.SecondaryNumber)) {
        //        line2.Append(this.Components.SecondaryNumber + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.DefaultCityName)) {
        //        address.City = this.Components.DefaultCityName;
        //    }
        //    else {
        //        address.City = this.Components.CityName;
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StateAbbreviation)) {
        //        address.StProvince = this.Components.StateAbbreviation;
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.Zipcode)) {
        //        address.PostalCode = this.Components.Zipcode;
        //    }

        //    address.Address1 = line1.ToString();
        //    address.Address2 = line2.ToString();

        //    return address;
        //}

        //public ChurchCommunityBuilder.Api.People.Entity.Address ConvertToCCBAddress() {
        //    var address = new ChurchCommunityBuilder.Api.People.Entity.Address();
        //    var line1 = new System.Text.StringBuilder();
        //    var line2 = new System.Text.StringBuilder();

        //    if (!string.IsNullOrEmpty(this.Components.PrimaryNumber)) {
        //        line1.Append(this.Components.PrimaryNumber + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StreetPredirection)) {
        //        line1.Append(this.Components.StreetPredirection + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StreetName)) {
        //        line1.Append(this.Components.StreetName + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StreetSuffix)) {
        //        line1.Append(this.Components.StreetSuffix + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.SecondaryDesignator)) {
        //        line2.Append(this.Components.SecondaryDesignator + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.SecondaryNumber)) {
        //        line2.Append(this.Components.SecondaryNumber + " ");
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.DefaultCityName)) {
        //        address.City = this.Components.DefaultCityName;
        //    }
        //    else {
        //        address.City = this.Components.CityName;
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.StateAbbreviation)) {
        //        address.State = this.Components.StateAbbreviation;
        //    }
        //    if (!string.IsNullOrEmpty(this.Components.Zipcode)) {
        //        address.Zip = this.Components.Zipcode;
        //    }

        //    address.Line1 = line1.ToString();
        //    address.Line2 = line2.ToString();

        //    return address;
        //}
    }
}