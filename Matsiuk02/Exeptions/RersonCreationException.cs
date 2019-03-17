using System;

namespace Matsiuk02.Exeptions
{
    public class PersonCreationException : Exception
    {
        public PersonCreationException(string message)
            : base(message)
        {
        }
    }
}
