using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class MethodsInfo
    {
        public System.String CurrencyCode                          { get; set; }
        public List<PaymentRegion> Region                          { get; set; }
        public List<PaymentProvider> Provider                      { get; set; }
        public List<PaymentSpecification> Specification            { get; set; }
        public List<PaymentExecutionDetail> PaymentExecutionDetail { get; set; }
        public System.String PaymentDepositUrl                     { get; set; }
        public System.String PaymentDepositDuration                { get; set; }
        public List<DepositUnavailabilityReason> UnavailabilityReasons { get; set; }
        public Int64 Id { get; set; }
    }
}