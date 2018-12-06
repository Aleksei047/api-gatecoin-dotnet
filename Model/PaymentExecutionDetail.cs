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
    public class PaymentExecutionDetail
    {
        String ActionType { get; set; }
        String UserMessage { get; set; }
        Int32 Id { get; set; }
    }
}
