using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matsiuk02.Exeptions
{
    internal class FutureBirthdayException : Exception
    {
        private string _message;
        private DateTime? _date;

        public override string Message
        {
            get => _message;
        }

        public FutureBirthdayException(string message)
        {
            _message = message;
        }

        public FutureBirthdayException(DateTime badDate)
        {
            _date = badDate;
            _message = $"A date from future was passed: {_date.ToString()}";
        }

        public FutureBirthdayException(DateTime badDate, string message)
        {
            _date = badDate;
            _message = message;
        }
    }
}
