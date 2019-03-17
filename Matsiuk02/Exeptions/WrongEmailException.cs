namespace Matsiuk02.Exeptions
{
    public class WrongEmailException : PersonCreationException
    {
        public WrongEmailException(string givenEmail)
            : base($"Email {givenEmail} is invalid")
        {
        }
    }
}
