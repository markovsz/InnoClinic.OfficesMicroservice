using Application.Commands.UpdateOffice;
using Domain.Enums;
using FluentValidation;

namespace Application.Commands.ChangeOfficeStatus
{
    public class ChangeOfficeStatusCommandValidator : AbstractValidator<ChangeOfficeStatusCommand>
    {
        public ChangeOfficeStatusCommandValidator() 
        {
            RuleFor(e => e.Status).IsEnumName(typeof(OfficeStatus));
        }
    }
}
