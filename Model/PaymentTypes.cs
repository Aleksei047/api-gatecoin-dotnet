using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class PaymentTypes
    {
        public System.String  Name { get; set; }
        public System.Int64   Id { get; set; }
    }
}