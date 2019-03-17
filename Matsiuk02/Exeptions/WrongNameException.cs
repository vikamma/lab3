namespace Matsiuk02.Exeptions
{
    public class WrongNameException : PersonCreationException
    {
        public WrongNameException() : base("First name is too short or contains numbers")

        {
        }
    }

}
