using Matsiuk02.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Matsiuk02.Models

{

  public class Person
    {

       
        private string _name;
        private string _surname;
        private string _email;
        private DateTime _date;
      



        internal string Surname
        {
            get { return _surname; }
            private set { _surname = value; }
        }

        internal string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        internal string Email
        {
            get { return _email; }
            private set {
                SignInValidator.ValidateEmail(this);
                _email = value; }
        }

        internal DateTime Date
        {

            get { return _date; }
            private set
            {
                SignInValidator.ValidateBirthday(this);
                _date = value;
            }
        }

        #region Constructor

        public Person(string name, string surname, string email, DateTime date)

        {
         
            _name = name;
            _surname = surname;
            _email = email;
            _date = date;
            new SignInValidator(this);
        }

        public Person(string name, string surname, string email)
        {

            _name = name;
            _surname = surname;
            _email = email;
            _date = DateTime.Now;
            new SignInValidator(this);
        }

        public Person(string name, string surname, DateTime date)
        {

            _name = name;
            _surname = surname;
            _email = "default@ukr.net";
            _date = date;
            new SignInValidator(this);
        }

        #endregion

        internal bool IsAdult
        {
            get { return UserAdult(_date); }

        }

        internal string Zodiac1
        {
            get { return GetWesternHoroscope(_date); }

        }

        internal string Zodiac2
        {
            get { return GetChinaHoroscope(_date); }

        }

        internal bool IsBirthday
        {
            get { return (_date.CompareTo(DateTime.Today) == 0) ? true : false; }
        }

     
        public bool UserAdult(DateTime _date)
        {
            DateTime currentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            int _age = currentDate.Year - _date.Year;
            if (currentDate.Month < _date.Month)
            {
                 --_age;
            }
            else if ((currentDate.Month >= _date.Month)
                     && (currentDate.Day < _date.Day))
            {
                 --_age;
            }

            if (_age >= 18)
                return true;
            

            return false;

        }

        public string GetWesternHoroscope(DateTime _date)
        {
            switch (_date.Month)
            {
                case 1:
                    return _date.Day <= 19 ? "Capricorn" : "Aquarius";
                case 2:
                    return _date.Day <= 18 ? "Aquarius" : "Pisces";

                case 3:
                    return _date.Day <= 20 ? "Pisces" : "Aries";

                case 4:
                    return _date.Day <= 19 ? "Aries" : "Taurus";

                case 5:
                    return _date.Day <= 20 ? "Taurus" : "Gemini";

                case 6:
                    return _date.Day <= 20 ? "Gemini" : "Cancer";

                case 7:
                    return _date.Day <= 22 ? "Cancer" : "Leo";

                case 8:
                    return _date.Day <= 22 ? "Leo" : "Virgo";

                case 9:
                    return _date.Day <= 22 ? "Virgo" : "Libra";

                case 10:
                    return _date.Day <= 22 ? "Libra" : "Scorpio";

                case 11:
                    return _date.Day <= 21 ? "Scorpio" : "Sagittarius";

                case 12:
                    return _date.Day <= 21 ? "Sagittarius" : "Capricorn";

            }

            return "";
        }

        public string GetChinaHoroscope(DateTime _date)
        {
            switch ((_date.Year - 4) % 12)
            {
                case 0:
                    return "Rat";
                case 1:
                    return "Ox";
                case 2:
                    return "Tiger";
                case 3:
                    return "Rabbit";
                case 4:
                    return "Dragon";
                case 5:
                    return "Snake";
                case 6:
                    return "Horse";
                case 7:
                    return "Goat";
                case 8:
                    return "Monkey";
                case 9:
                    return "Rooster";
                case 10:
                    return "Dog";
                case 11:
                    return "Pig";

            }

            return "";
        }
    }
}

