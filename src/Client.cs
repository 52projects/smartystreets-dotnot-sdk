using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartyStreets.Api.Entity;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace SmartyStreets.Api {
    public class Client {
        #region Properties
        private string _apiUrl = "https://api.smartystreets.com";
        private string _authID = null;
        private string _authToken = null;
        #endregion Properties

        #region Constructor
        public Client(string authID, string authToken) {
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

        //public Address NormalizeAddress(string address) {
        //    System.Text.StringBuilder url = new StringBuilder();
        //    url.Append("https://extract-beta.api.smartystreets.com?input=");
        //    url.Append(address.ToLower().Replace("apt", "").UrlEncode());
        //    url.Append("&auth-id=").Append(_authID);
        //    url.Append("&auth-token=").Append(_authToken);

        //    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url.ToString());
        //    webRequest.Method = "GET";
        //    webRequest.KeepAlive = true;
        //    webRequest.Headers.Add("Accept-Language", "en-us,en;q=0.5");

        //    using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse()) {
        //        using (var stream = new StreamReader(webResponse.GetResponseStream())) {
        //            string streamText = stream.ReadToEnd();
        //            dynamic result = JsonConvert.DeserializeObject(streamText);

        //            var addresses = result.addresses.ToString();

        //            if (!string.IsNullOrEmpty(addresses) && addresses != "[]") {
        //                var addressResult = result.addresses[0];
        //                var apiOutput = addressResult.api_output.ToString();
        //                if (!string.IsNullOrEmpty(apiOutput) && apiOutput != "[]") {
        //                    return JsonConvert.DeserializeObject<Address>(addressResult.api_output[0].ToString());
        //                }
        //            }
        //        }
        //    }

        //    return null;
        //}
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}
