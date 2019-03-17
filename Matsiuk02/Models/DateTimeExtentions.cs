using System;

namespace Matsiuk02.Models
{
    public static class DateTimeExtensions
    {
        public static int HowYearsOld(this DateTime thisDateTime, DateTime anotherDateTime)
        {
            return (thisDateTime.Year - anotherDateTime.Year) - (thisDateTime.DayOfYear >= anotherDateTime.DayOfYear ? 0 : 1);
        }
    }
}
