namespace Matsiuk02.Exeptions
{
    public class WrongSurnameException : PersonCreationException
    {
        public WrongSurnameException() : base("Last name is too short or contains numbers")



        {
        }
    }
}
