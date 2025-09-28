using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CurrencyUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CurrencyUpdateModel>>]
public partial class CurrencyUpdateModelValidator
    : AbstractValidator<CurrencyUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyUpdateModelValidator"/> class.
    /// </summary>
    public CurrencyUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CurrencyCode).NotEmpty();
        RuleFor(p => p.CurrencyCode).MaximumLength(3);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
