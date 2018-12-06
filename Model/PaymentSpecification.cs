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
    public class PaymentSpecification
    {
        public Double MinLimit                  { get; set; }
        public Double MaxLimit                  { get; set; }
        public Double ProviderFeePercentage     { get; set; }
        public Double ProviderFeeFixed          { get; set; }
        public Double InternalFeePercentage     { get; set; }
        public Double InternalFeeFixed          { get; set; }
        public Int32 Id                         { get; set; }
    }
}
