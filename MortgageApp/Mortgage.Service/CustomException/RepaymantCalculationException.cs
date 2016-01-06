using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage.Service.CustomException
{
    public class RepaymantCalculationException : Exception
    {
         /// The error code. 
         /// Comes from ExceptionCode
        public int code { get; set; }

        public RepaymantCalculationException(String message, int code)
            : base(message)
        {
            this.code = code;
        }
    }
}
