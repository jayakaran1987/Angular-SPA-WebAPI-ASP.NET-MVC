using Mortgage.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage.Service.Interface
{
    public interface IRepaymentService
    {
        // Impleneted in RepaymentService.cs
        double MonthlyPaymentAmount(Repayment payment);
        double AmountPaidBack(Repayment payment);

    }
}
