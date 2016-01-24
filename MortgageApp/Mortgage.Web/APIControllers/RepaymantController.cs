using Mortgage.Service;
using Mortgage.Service.Interface;
using Mortgage.Service.Model;
using Mortgage.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mortgage.Web.APIControllers
{
    public class RepaymantController : ApiBaseController
    {
        private readonly IRepaymentService paymentService;

        RepaymantController()
        {
            // Replace this with IoC 
            // Can Use TinyIoc, Unity, Ninject, Autofac etc
            paymentService = new RepaymentService();
        }

        [HttpPost]
        [Route("api/Repaymant/getRepaymentData/{model}")]
        public RepaymantViewModel getRepaymentData(RepaymantViewModel model)
        {
            try
            {
                // We can use Automapper to Map View Model to Model
                var paymant = new Repayment() { LoanAmount = model.LoanAmount, AnnualInterestRate = model.AnnualInterestRate, TermYears = model.TermYears, TermMonths = model.TermMonths };

                model.MonthlyRepaymant = paymentService.MonthlyPaymentAmount(paymant);
                model.TotalToBePaid = paymentService.AmountPaidBack(paymant);

                return model;
            }
            catch (Exception e)
            {
                throw new HttpResponseException(Request.CreateResponse(
                HttpStatusCode.NotAcceptable, new ErrorResponseView(e).message));
            }
        }


        // Common Api methods

        //// GET api/repaymant
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/repaymant/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/repaymant
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/repaymant/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/repaymant/5
        //public void Delete(int id)
        //{
        //}
    }
}
