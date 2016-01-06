using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage.Service.Model
{
    public class Repayment
    {
        // core Model
        // Used in calculation
        public double LoanAmount { get; set; }
        public double AnnualInterestRate { get; set; }
        public int TermYears{ get; set; }
        public int TermMonths{ get; set; }
    }
}
