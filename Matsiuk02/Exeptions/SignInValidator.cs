using Matsiuk02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matsiuk02.Exeptions
{
    internal class SignInValidator
    {
        private Person _person;

        public SignInValidator(Person person)
        {
            _person = person;
            Validate();
        }

        public static void ValidateBirthday(Person person)
        {
            if (person.Date >= DateTime.Today)
            {
                throw new FutureBirthdayException("You cannot register unborn people!");
            }
            if (DateTime.Today.Year - person.Date.Year > 135)
            {
                throw new DistantPastBirthdayException("The user is dead. Do not register dead men.");
            }
        }

        public static void ValidateEmail(Person person)
        {
            if (!CorrectEmail(person))
            {
                throw new InvalidEmailException("An email you are trying to pass is not supported!");
            }
        }

        public static bool CorrectEmail(Person person)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(person.Email);
                return addr.Address == person.Email;
            }
            catch
            {
                return false;
            }
        }

        private void Validate()
        {
            CheckBDay();
            CheckEmail();
        }

        private void CheckBDay()
        {
            if (_person.Date >= DateTime.Today)
            {
                throw new FutureBirthdayException("You cannot register unborn people!");
            }
            if (DateTime.Today.Year - _person.Date.Year > 135)
            {
                throw new DistantPastBirthdayException("The user is dead. Do not register dead men.");
            }
        }

        private void CheckEmail()
        {
            if (!CorrectEmail(_person))
            {
                throw new InvalidEmailException("An email you are trying to pass is not supported!");
            }
        }
    }
}
