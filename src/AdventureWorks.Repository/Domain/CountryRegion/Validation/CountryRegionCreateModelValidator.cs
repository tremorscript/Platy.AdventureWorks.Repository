using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CountryRegionCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CountryRegionCreateModel>>]
public partial class CountryRegionCreateModelValidator
    : AbstractValidator<CountryRegionCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionCreateModelValidator"/> class.
    /// </summary>
    public CountryRegionCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CountryRegionCode).NotEmpty();
        RuleFor(p => p.CountryRegionCode).MaximumLength(3);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
