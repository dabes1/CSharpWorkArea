using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// added using
using PayPal.Api;

namespace CSharpWorkArea.PayPalClassObjects
{
    public abstract class PayPalBase
    {
        // private internal objects
        protected readonly string _accessToken = string.Empty;
        protected readonly APIContext _apiContext = null;

        private string _clientId = "";
        private string _clientSecret = "";

        // constructor
        public PayPalBase(string inContext)
        {
            if (string.IsNullOrEmpty(_accessToken))
            {
                _accessToken = new OAuthTokenCredential(_clientId, _clientSecret).GetAccessToken();
                _apiContext = new APIContext(_accessToken);
            }
        }

        protected APIContext GetApiContext()
        {
            return _apiContext;
        }

    }
}
