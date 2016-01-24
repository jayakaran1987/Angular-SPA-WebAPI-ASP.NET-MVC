using Mortgage.Service;
using Mortgage.Service.CustomException;
using Mortgage.Service.Interface;
using Mortgage.Service.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage.Test
{
    [TestFixture]
    public class RepaymentServiceTest
    {
        // Initialize repaymantService 
        private IRepaymentService paymentService;

        [SetUp]
        public void SetUp()
        {
            this.paymentService = new RepaymentService();
        }

        [Test]
        public void RepaymantServieTestCase1()
        {
            /*  Loan amount = 145000
                Annual Interest rate = 4.5 (note this is the annual interest rate and we require a monthly repayment figure)
                Term years = 23
                Term months = 7
                The resulting monthly repayment = 832.33
                Total to be repaid = 235549.39 */

            Repayment paymentTest = new Repayment() { AnnualInterestRate = 4.5, LoanAmount = 145000, TermMonths = 7, TermYears =23  };

            var monthlyPaymant = paymentService.MonthlyPaymentAmount(paymentTest);
            var totalToBePaid = paymentService.AmountPaidBack(paymentTest);

            Assert.That(monthlyPaymant, Is.EqualTo(832.33));
            Assert.That(totalToBePaid, Is.EqualTo(235549.39));
        }

        [Test]
        public void RepaymantServieTestCase2()
        {
            /* 
                Given the following inputs:
                Loan amount =  290000
                Annual Interest rate = 7.5 (note this is the annual interest rate and we require a monthly repayment figure)
                Term years = 15
                Term months = 6
                The resulting monthly repayment = 2641.50
                Total to be repaid = 491319.00
             */

            Repayment paymentTest = new Repayment() { AnnualInterestRate = 7.5, LoanAmount = 290000, TermMonths = 6, TermYears = 15 };

            var monthlyPaymant = paymentService.MonthlyPaymentAmount(paymentTest);
            var totalToBePaid = paymentService.AmountPaidBack(paymentTest);

            Assert.That(monthlyPaymant, Is.EqualTo(2641.50));
            Assert.That(totalToBePaid, Is.EqualTo(491319.00));
        }

        [Test]
        public void RepaymantServieThrowsRepaymantCalculationExceptionCase1()
        {
            /* 
                Given the following inputs:
                Loan amount =  290000
                Annual Interest rate = 7.5 (note this is the annual interest rate and we require a monthly repayment figure)
                Term years = 0
                Term months = 0
                This should cause an error to occur in the calculation which must be trapped and displayed to the user in a friendly manner
             */

            try
            {
                Repayment paymentTest = new Repayment() { AnnualInterestRate = 7.5, LoanAmount = 290000, TermMonths = 0, TermYears = 0 };

                var monthlyPaymant = paymentService.MonthlyPaymentAmount(paymentTest);
                var totalToBePaid = paymentService.AmountPaidBack(paymentTest);
            }
            catch (Exception e)
            {
                int? c = null;
                if (e is RepaymantCalculationException) c = (e as RepaymantCalculationException).code;
                Assert.That(c, Is.EqualTo(100));
            }
        }


        // We can write more function test cases to ensure the service and api controller works as expected
        // I have tested the main logic
    }
}
