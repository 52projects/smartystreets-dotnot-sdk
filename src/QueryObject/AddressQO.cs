using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartyStreets.Api.Attributes;

namespace SmartyStreets.Api.QueryObject {
    public class AddressQO : BaseQO {
        [QO("input_id")]
        public string InputID { get; set; }

        [QO("street")]
        public string Street { get; set; }

        [QO("street2")]
        public string Street2 { get; set; }

        [QO("city")]
        public string City { get; set; }

        [QO("state")]
        public string State { get; set; }

        [QO("zipcode")]
        public string Zipcode { get; set; }

        [QO("input")]
        public string Input { get; set; }
    }
}
