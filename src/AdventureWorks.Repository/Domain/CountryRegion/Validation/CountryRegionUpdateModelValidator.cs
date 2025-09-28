using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CountryRegionUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CountryRegionUpdateModel>>]
public partial class CountryRegionUpdateModelValidator
    : AbstractValidator<CountryRegionUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionUpdateModelValidator"/> class.
    /// </summary>
    public CountryRegionUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
