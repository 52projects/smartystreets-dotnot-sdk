using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartyStreets.Api {
    public class ExtractClient {
        #region Properties
        private string _apiUrl = "https://extract-beta.api.smartystreets.com";
        private string _authID = null;
        private string _authToken = null;
        #endregion Properties

        #region Constructor
        public ExtractClient(string authID, string authToken) {
            _authID = authID;
            _authToken = authToken;
        }
        #endregion Constructor

        private SmartyStreets.Api.Sets.AddressSet _addressSet = null;
        public SmartyStreets.Api.Sets.AddressSet Addresses {
            get {
                if (_addressSet == null) {
                    _addressSet = new Sets.AddressSet(_apiUrl);
                }

                return _addressSet;
            }
        }
    }
}
