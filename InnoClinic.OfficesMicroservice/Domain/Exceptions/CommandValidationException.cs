namespace Domain.Exceptions
{
    public class CommandValidationException : Exception
    {
        public CommandValidationException(string message)
            : base(message)
        {
        }
    }
}
