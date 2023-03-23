using Application.Abstractions.Messaging;
using Domain.Exceptions;
using FluentValidation;

namespace Application.Behaviors
{
    public sealed class QueryValidationBehavior<TRequest, TResponse> : BaseValidationBehavior<TRequest, TResponse>
    where TRequest : class, IQuery<TResponse>
    {
        public QueryValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
            : base(validators)
        {
        }

        protected override void ThrowAnException(string message)
        {
            throw new QueryValidationException(message);
        }
    }
}
