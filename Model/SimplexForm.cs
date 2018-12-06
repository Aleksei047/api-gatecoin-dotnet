using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class SimplexForm
    {
        public String Version { get; set; }
        public String PartnerName { get; set; }
        public String RedirectUrl { get; set; }
        public String ReturnUrl { get; set; }
        public String PaymentId { get; set; }
        public String PaymentFlow { get; set; }
        public Double Amount { get; set; }
        public String Currency { get; set; }
        public Int64  TraderId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Pnone { get; set; }
    }
}