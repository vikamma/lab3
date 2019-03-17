using Matsiuk02.Exeptions;
using System;
using System.Text.RegularExpressions;

namespace Matsiuk02.Models
{

    public class Person
    {
        internal readonly string Name;
        internal readonly string Surname;
        internal readonly string Email;
        internal readonly DateTime Date;

        public Person(string name, string surname, string email, DateTime date)
        {
           
            if (name.Length <= 1 || name.Contains("0") || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9"))
            {
                throw new WrongNameException();
            }
            if (surname.Length <= 1 || surname.Contains("0") || surname.Contains("1") || surname.Contains("2") || surname.Contains("3") || surname.Contains("4") || surname.Contains("5") || surname.Contains("6") || surname.Contains("7") || surname.Contains("8") || surname.Contains("9"))
            {
                throw new WrongSurnameException();
            }

            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!emailRegex.IsMatch(email))
            {
                throw new WrongEmailException(email);
            }

            var yearsDif = DateTime.Today.HowYearsOld(date);
            if (yearsDif < 0 )
            {
                throw new WrongBirthdayEarlyException(name);
            }

            if (yearsDif > 135)
            {
                throw new WrongBirthdayLateException(name);
            }

            Name = name;
            Surname = surname;
            Email = email;
            Date = date;
        }
        public Person(string name, string surname, DateTime date) 
        {
            Name = name;
            Surname = surname;
            Email = "default@email.com";
            Date = date;
        }

        public Person(string name, string surname, string email) 
        {
            Name = name;
            Surname = surname;
            Email = email;
            Date = DateTime.Now;
        }


        public bool IsAdult => DateTime.Today.HowYearsOld(Date) >= 18;
        public bool IsBirthday => DateTime.Today.Day == Date.Day && DateTime.Today.Month == Date.Month;

        public string Zodiac1
        {
            get
            {
                return GetChinaHoroscope();
            }
        }

        public string Zodiac2
        {
            get { return GetWesternHoroscope(); }
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