using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortgage.Service.CustomException
{
    public static class ExceptionCode
    {
        // Repaymant terms couldnot be 0 or less
        public static int REPAYMENT_TERM_EQUALS_TO_0 = 100;
        // Unhandled Exception
        public static int UN_HANDLED = 101;
        //-------------------
        // Add more expections 
    }
}
