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
    public class CurrenciesInfo
    {
        public System.String  CurrencyCode { get; set; }
        public System.Boolean IsDepositEnabled { get; set; }
        public System.Boolean IsWithdrawalEnabled { get; set; }
        public System.Boolean IsAlternative { get; set; }
    }
}