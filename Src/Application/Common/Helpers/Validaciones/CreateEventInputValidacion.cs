using Application.DTOs.Event;
using FluentValidation;

namespace Application.Common.Helpers.Validaciones
{
    public class CreateEventInputValidacion: AbstractValidator<CreateEventInput>
    {
        CreateEventInputValidacion()
        {
            RuleFor(input => input.EventType)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => TipoExcepcionTecnica.EventTypeEmpty.GetDescription());

            RuleFor(input => input.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => TipoExcepcionTecnica.DescriptionEmpty.GetDescription());

            RuleFor(input => input.DateEvent)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => TipoExcepcionTecnica.DateEventEmpty.GetDescription());
        }
    }
}
