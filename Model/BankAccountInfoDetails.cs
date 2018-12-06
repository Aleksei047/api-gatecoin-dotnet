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
    public class BankAccountInfoDetails
    {
        public String BeneficiaryName { get; set; }
        public String BeneficiaryAddress { get; set; }
        public String BeneficiaryBank { get; set; }
        public String IBANCode { get; set; }
        public String SWIFTCode { get; set; } 
        public String CreditCode { get; set; }
        public Int32 WiredTransferBankAccountId { get; set; }
        public Int32 Id { get; set; }
    }
}
