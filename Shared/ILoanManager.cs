using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shared
{
    [ServiceContract(Name = "Service.LoanManager")]
    public interface ILoanManager
    {
        //decimal GetNextPaymentAmount(string loanApplicationId,DateTime date);
        //decimal GetFirstPaymentAmount(string loanApplicationId);

        //int? GetAmount();
        string GetText(string text);
        //ValueTask<int> MultiplyAsync(string request);
    }
}
