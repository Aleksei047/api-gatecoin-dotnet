using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response
{
    public class PaymentAvailableMethods : CommonResponse
    {
        public String DepositReferenceCode { get; set; }
        public List<MethodsInfo> DepositPaymentMethods { get; set; }
    }
}