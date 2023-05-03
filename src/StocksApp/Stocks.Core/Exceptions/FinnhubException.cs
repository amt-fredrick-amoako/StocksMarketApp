using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Core.Exceptions
{
    /// <summary>
    /// Represents database connection or update failure
    /// </summary>
    public class FinnhubException : Exception
    {
        public FinnhubException()
        {

        }
        public FinnhubException(string message) : base(message)
        {

        }
        public FinnhubException(string message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
