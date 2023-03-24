using FluentValidation;
using MediatR;
using Newtonsoft.Json;

namespace Application.Behaviors
{
    public abstract class BaseValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : class, IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public BaseValidationBehavior(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;

        private Dictionary<string, string[]> RetrieveErrors(TRequest request)
        {
            var context = new ValidationContext<TRequest>(request);
            var errorsDictionary = _validators
                .Select(x => x.Validate(context))
                .SelectMany(x => x.Errors)
                .Where(x => x != null)
                .GroupBy(
                    x => x.PropertyName,
                    x => x.ErrorMessage,
                    (propertyName, errorMessages) => new
                    {
                        Key = propertyName,
                        Values = errorMessages.Distinct().ToArray()
                    })
                .ToDictionary(x => x.Key, x => x.Values);
            return errorsDictionary;
        }

        protected virtual void ThrowAnException(string message)
        {
            throw new ValidationException(message);
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_validators.Any())
            {
                return await next();
            }

            var errorsDictionary = RetrieveErrors(request);

            if (errorsDictionary.Any())
            {
                var errors = JsonConvert.SerializeObject(errorsDictionary);
                ThrowAnException(errors);
            }
            return await next();
        }
    }
}
