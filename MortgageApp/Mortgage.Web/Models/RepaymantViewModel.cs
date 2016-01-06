using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mortgage.Web.Models
{
    // View Model used in Views 
    public class RepaymantViewModel
    {
        public double LoanAmount { get; set; }
        public double AnnualInterestRate { get; set; }
        public int TermYears { get; set; }
        public int TermMonths { get; set; }

        // Results after Calculation
        public double MonthlyRepaymant { get; set; }
        public double TotalToBePaid{ get; set; }
    }
}