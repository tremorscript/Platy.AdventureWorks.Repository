using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ScrapReasonCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ScrapReasonCreateModel>>]
public partial class ScrapReasonCreateModelValidator
    : AbstractValidator<ScrapReasonCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrapReasonCreateModelValidator"/> class.
    /// </summary>
    public ScrapReasonCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
