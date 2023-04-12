using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class LoanApplication
    {
        [DataMember(Order = 1)]
        public string LoanApplicationID { get; set; }
        [DataMember(Order = 2)]
        public List<Payment> Payments { get; set; }
    }

    [DataContract]
    public class Payment
    {
        [DataMember(Order = 1)]
        public DateTime PaymentDate { get; set; }

        [DataMember(Order = 2)]
        public decimal Amount { get; set; }

    }
}
