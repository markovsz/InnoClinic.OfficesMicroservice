namespace Domain.Exceptions
{
    public class QueryValidationException : Exception
    {
        public QueryValidationException(string message)
            : base(message)
        {
        }
    }
}
