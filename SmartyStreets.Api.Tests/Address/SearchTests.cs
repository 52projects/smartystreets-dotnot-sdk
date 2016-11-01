using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartyStreets.Api.Entity;
using SmartyStreets.Api.QueryObject;

namespace SmartyStreets.Api.Tests.Addresses {
    [TestClass]
    public class SearchTests {
        private Client _smartyStreetsClient = null;

        [TestInitialize]
        public void Setup() {
        }
        [TestMethod]
        public void integration_search_for_address() {
            var qo = new SmartyStreets.Api.QueryObject.AddressQO();
            qo.Street = "111 SW 5th Ave, Portland, OR 97204";
            var results = this._smartyStreetsClient.Addresses.Search<List<Address>>(qo);
        }
    }
}
