using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartyStreets.Api.Entity;
using System.Collections.Generic;

namespace SmartyStreets.Api.Tests.Addresses
{
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
