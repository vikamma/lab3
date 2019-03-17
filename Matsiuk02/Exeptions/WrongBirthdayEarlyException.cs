namespace Matsiuk02.Exeptions
{
    public class WrongBirthdayEarlyException : PersonCreationException
    {
        public WrongBirthdayEarlyException(string name)
            : base($"Person {name} wasn`t born yet!")
        {
        }
    }
}
