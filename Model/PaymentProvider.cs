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
    public class PaymentProvider
    {
        public System.Boolean IsKycRequired { get; set; }
        public List<BankAccountInfoDetails> BankAccountInfo { get; set; }
        public List<PaymentTypes> PaymentType { get; set; }
        public System.String Name { get; set; }
        public System.Int64 Id { get; set; }
    }
}