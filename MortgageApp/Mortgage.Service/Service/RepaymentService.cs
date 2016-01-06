using Mortgage.Service.CustomException;
using Mortgage.Service.Interface;
using Mortgage.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage.Service
{
    public class RepaymentService : IRepaymentService
    {
        // get Payment amount
        // The formula for calculating the monthly payment amount is in WIKI
        // https://en.wikipedia.org/wiki/Mortgage_calculator
        public double MonthlyPaymentAmount(Repayment payment)
        {
            if (payment.TermMonths <= 0 && payment.TermYears <= 0)
            {
                throw new RepaymantCalculationException("Minimum Repaymant term should be one month or more", ExceptionCode.REPAYMENT_TERM_EQUALS_TO_0);
            }
            try
            {
                var repaymentMonths = (payment.TermYears * 12) + payment.TermMonths;
                double rate = payment.AnnualInterestRate / 100 / 12;
                double denaminator = Math.Pow((1 + rate), repaymentMonths) - 1;
                return Math.Round((rate + (rate / denaminator)) * payment.LoanAmount, 2, MidpointRounding.AwayFromZero);
            }
            catch (Exception e)
            {
                throw new RepaymantCalculationException(e.Message, ExceptionCode.UN_HANDLED);
            }
           
        }



        // Total amount pay back when the completion of total repaymants
        public double AmountPaidBack(Repayment payment)
        {
            if (payment.TermMonths <= 0 && payment.TermYears <= 0)
            {
                throw new RepaymantCalculationException("Minimum Repaymant term should be one month or more", ExceptionCode.REPAYMENT_TERM_EQUALS_TO_0);
            }
            var repaymentMonths = (payment.TermYears * 12) + payment.TermMonths;
            return Math.Round((MonthlyPaymentAmount(payment) * repaymentMonths), 2, MidpointRounding.AwayFromZero);
        }

    }
}
