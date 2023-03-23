using Domain.Enums;
using FluentValidation;

namespace Application.Commands.CreateOffice
{
    public class CreateOfficeCommandValidator : AbstractValidator<CreateOfficeCommand>
    {
        public CreateOfficeCommandValidator()
        {
            RuleFor(e => e.Status).IsEnumName(typeof(OfficeStatus));
        }
    }
}
