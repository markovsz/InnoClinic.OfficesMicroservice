using Domain.Enums;
using FluentValidation;

namespace Application.Commands.UpdateOffice
{
    public class UpdateOfficeCommandValidator : AbstractValidator<UpdateOfficeCommand>
    {
        public UpdateOfficeCommandValidator() 
        {
            RuleFor(e => e.Status).IsEnumName(typeof(OfficeStatus));
        }
    }
}
