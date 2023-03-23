using Application.Abstractions.Messaging;
using Application.Behaviors;
using Domain.Exceptions;
using FluentValidation;
using MediatR;
using Newtonsoft.Json;

namespace Infrastructure.Validators
{
    public sealed class CommandValidationBehavior<TRequest, TResponse> : BaseValidationBehavior<TRequest, TResponse>
    where TRequest : class, ICommand<TResponse>
    {
        public CommandValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
            : base(validators) 
        {
        }

        protected override void ThrowAnException(string message)
        {
            throw new CommandValidationException(message);
        }
    }
}
