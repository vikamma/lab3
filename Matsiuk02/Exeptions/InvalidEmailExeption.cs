using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matsiuk02.Exeptions
{
    class InvalidEmailException : Exception
    {
        private string _message;

        public override string Message
        {
            get => _message;
        }

        public InvalidEmailException(string message)
        {
            _message = message;
        }
    }
}
