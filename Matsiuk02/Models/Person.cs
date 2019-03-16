
using System;
using System.Text.RegularExpressions;

namespace Matsiuk02.Models

{
    public class PersonCreationException : Exception
    {
        public PersonCreationException(string message)
            : base(message)
        {
        }
    }

    public class WrongNameException : PersonCreationException
    {
        public WrongNameException(string message)
            : base(message)
        {
        }
    }

    public class WrongSurnameException : PersonCreationException
    {
        public WrongSurnameException(string message)
            : base(message)
        {
        }
    }

    public class WrongEmailException : PersonCreationException
    {
        public WrongEmailException(string givenEmail)
            : base($"Email {givenEmail} is not valid!")
        {
        }
    }

    public class WrongBirthdayEarlyException : PersonCreationException
    {
        public WrongBirthdayEarlyException(DateTime birthday)
            : base($"Birthday {birthday.ToShortDateString()} is not valid!")
        {
        }
    }
    public class WrongBirthdayLateException : PersonCreationException
    {
        public WrongBirthdayLateException(DateTime birthday)
            : base($"Birthday {birthday.ToShortDateString()} is not valid!")
        {
        }
    }


    public class Person
    {


        internal readonly string Name;
        internal readonly string Surname;
        internal readonly string Email;
        internal readonly  DateTime Date;



        #region Constructor

        public Person(string name, string surname, string email, DateTime date)
        {
            string _numb = "1234567890";
            if (name.Length < 2 || name.Contains(_numb))
            {
                throw new WrongNameException($"Name {name} is too small or conteins numbers");
            }
            if (surname.Length < 2 || surname.Contains(_numb))
            {
                throw new WrongSurnameException($"Name {name} is too small or conteins numbers");
            }
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!emailRegex.IsMatch(Email))
            {
                throw new WrongEmailException(Email);
            }
           

            
            if (Age < 0 )
            {
                throw new WrongBirthdayEarlyException(Date);
            }
            if ( Age > 135)
            {
                throw new WrongBirthdayLateException(Date);
            }


            Name = name;
            Surname = surname;
            Email = email;
            Date = date;
        }

        public Person(string name, string surname, string email)
        {

            Name = name;
            Surname = surname;
            Email = email;
            Date = DateTime.Now;

        }

        public Person(string name, string surname, DateTime date)
        {

            Name = name;
            Surname = surname;
            Email = "default@ukr.net";
            Date = date;

        }

        #endregion

        internal bool IsAdult
        {
        
            get { return Age >= 18; }
        

        }

        internal string Zodiac1
        {
            get { return GetWesternHoroscope(); }

        }

        internal string Zodiac2
        {
            get { return GetChinaHoroscope(); }

        }

        internal bool IsBirthday
        {
            get { return (Date.CompareTo(DateTime.Today) == 0) ? true : false; }
        }


        private int  Age
        {
        
            get
            {
                int years = DateTime.Today.Year - Date.Year;
                if (DateTime.Today.Month < Date.Month)
                {
                    years--;
                }
                else if (DateTime.Today.Month == Date.Month)
                {
                    if (DateTime.Today.Day < Date.Day)
                    {
                        years--;
                    }
                }

                return years;
            }
        }

        

        public string GetWesternHoroscope()
        {
            switch (Date.Month)
            {
                case 1:
                    return Date.Day <= 19 ? "Capricorn" : "Aquarius";
                case 2:
                    return Date.Day <= 18 ? "Aquarius" : "Pisces";

                case 3:
                    return Date.Day <= 20 ? "Pisces" : "Aries";

                case 4:
                    return Date.Day <= 19 ? "Aries" : "Taurus";

                case 5:
                    return Date.Day <= 20 ? "Taurus" : "Gemini";

                case 6:
                    return Date.Day <= 20 ? "Gemini" : "Cancer";

                case 7:
                    return Date.Day <= 22 ? "Cancer" : "Leo";

                case 8:
                    return Date.Day <= 22 ? "Leo" : "Virgo";

                case 9:
                    return Date.Day <= 22 ? "Virgo" : "Libra";

                case 10:
                    return Date.Day <= 22 ? "Libra" : "Scorpio";

                case 11:
                    return Date.Day <= 21 ? "Scorpio" : "Sagittarius";

                case 12:
                    return Date.Day <= 21 ? "Sagittarius" : "Capricorn";

            }

            return "";
        }

        public string GetChinaHoroscope()
        {
            switch ((Date.Year - 4) % 12)
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