namespace Matsiuk02.Exeptions
{
    public class WrongBirthdayLateException : PersonCreationException
    {
        public WrongBirthdayLateException(string name)
            : base($"Person {name} should be died!")
        {
        }
    }
}
