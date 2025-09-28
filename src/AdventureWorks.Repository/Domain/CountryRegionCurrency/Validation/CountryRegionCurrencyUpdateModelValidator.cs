using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CountryRegionCurrencyUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CountryRegionCurrencyUpdateModel>>]
public partial class CountryRegionCurrencyUpdateModelValidator
    : AbstractValidator<CountryRegionCurrencyUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionCurrencyUpdateModelValidator"/> class.
    /// </summary>
    public CountryRegionCurrencyUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.CurrencyCode).NotEmpty();
        RuleFor(p => p.CurrencyCode).MaximumLength(3);
        #endregion
    }

}
