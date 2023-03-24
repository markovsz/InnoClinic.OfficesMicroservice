using FluentValidation;

namespace Application.Queries.GetOffices
{
    public class GetOfficesQueryValidator : AbstractValidator<GetOfficesQuery>
    {
        public GetOfficesQueryValidator()
        {
            RuleFor(e => e.Page).GreaterThanOrEqualTo(1);
            RuleFor(e => e.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
