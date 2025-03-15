using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Exceptions
{
    public class IncorretInputException : Exception
    {
        public IncorretInputException() : base("Incorrect input value")
        {
        }

        public IncorretInputException(string message) : base(message)
        {
        }

        public IncorretInputException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
