using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartyStreets.Api.Entity;
using RestSharp;

namespace SmartyStreets.Api.Sets {
    public class AddressSet : BaseApiSet<Address> {
        private const string SEARCH_URL = "/street-address";

        public AddressSet(string baseURl) : base(baseURl, ContentType.JSON) { }

        protected override string SearchUrl {
            get {
                return SEARCH_URL;
            }
        }
    }
}
