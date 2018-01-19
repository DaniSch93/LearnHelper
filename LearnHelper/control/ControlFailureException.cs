using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHelper.control
{
    class ControlFailureException : Exception
    {
        public ControlFailureException(string message) : base(message)
        {

        }
    }
}
