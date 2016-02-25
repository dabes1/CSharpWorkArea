using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Added usings
using PayPal.Api;


namespace CSharpWorkArea.PayPalClassObjects
{
    public class PaymentWithCreditCard : PayPalBase
    {

        // Constructor
        public PaymentWithCreditCard(string inContext)
            : base(inContext)            
        {
        }

        public APIContext GetCurrentApiContext()
        {
            return base.GetApiContext();
        }
    }
}
