using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartyStreets.Api.Entity {
    [DataContract]
    public class Address {
        public Address() {
            this.Components = new Component();
            this.MetaData = new MetaData();
        }
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
    }
}