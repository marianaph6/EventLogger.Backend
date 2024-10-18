using FluentValidation;
using FluentValidation.Results;

namespace Application.Common.Helpers.Validaciones
{
    public static class ValidatorExtensions
    {

        public static async Task ValidateAndThrowsAsync<T, TValidator>(this T element)
        where TValidator : IValidator<T>
        {
            TValidator validator = (TValidator)typeof(TValidator).New();

            ValidationResult validationResult = await validator.ValidateAsync(element);

            if (!validationResult.IsValid)
            {
                IEnumerable<string> aggregatedMessages = validationResult.Errors.Select(err => err.ErrorMessage);
                throw new BusinessException($"{string.Join(" | ", aggregatedMessages)}", (int)BusinessResponse.ReportTemplates_InputValidationErrors);
            }
        }
    }
}
