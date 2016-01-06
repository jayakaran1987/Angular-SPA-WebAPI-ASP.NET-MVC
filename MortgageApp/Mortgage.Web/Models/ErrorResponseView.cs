using Mortgage.Service.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mortgage.Web.Models
{
    public class ErrorResponseView
    {
        // Converting Custom exception here
        public String message { get; set; }

        public int? code { get; set; }

        public ErrorResponseView(System.Exception e)
        {
            int? c = null;
            if (e is RepaymantCalculationException) c = (e as RepaymantCalculationException).code;

            Initialize(e.Message, c);
        }
        protected void Initialize(String message, int? code)
        {
            this.code = code;
            this.message = message;
        }
    }
}