using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHelper.data
{
    class DatabaseFailureException : Exception
    {
        public DatabaseFailureException(string message): base(message)
        {

        }
    }
}
