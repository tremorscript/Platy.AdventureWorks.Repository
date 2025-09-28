using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VSalesPersonCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VSalesPersonCreateModel>>]
public partial class VSalesPersonCreateModelValidator
    : AbstractValidator<VSalesPersonCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonCreateModelValidator"/> class.
    /// </summary>
    public VSalesPersonCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Title).MaximumLength(8);
        RuleFor(p => p.FirstName).NotEmpty();
        RuleFor(p => p.FirstName).MaximumLength(50);
        RuleFor(p => p.MiddleName).MaximumLength(50);
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.LastName).MaximumLength(50);
        RuleFor(p => p.Suffix).MaximumLength(10);
        RuleFor(p => p.JobTitle).NotEmpty();
        RuleFor(p => p.JobTitle).MaximumLength(50);
        RuleFor(p => p.PhoneNumber).MaximumLength(25);
        RuleFor(p => p.PhoneNumberType).MaximumLength(50);
        RuleFor(p => p.EmailAddress).MaximumLength(50);
        RuleFor(p => p.AddressLine1).NotEmpty();
        RuleFor(p => p.AddressLine1).MaximumLength(60);
        RuleFor(p => p.AddressLine2).MaximumLength(60);
        RuleFor(p => p.City).NotEmpty();
        RuleFor(p => p.City).MaximumLength(30);
        RuleFor(p => p.StateProvinceName).NotEmpty();
        RuleFor(p => p.StateProvinceName).MaximumLength(50);
        RuleFor(p => p.PostalCode).NotEmpty();
        RuleFor(p => p.PostalCode).MaximumLength(15);
        RuleFor(p => p.CountryRegionName).NotEmpty();
        RuleFor(p => p.CountryRegionName).MaximumLength(50);
        RuleFor(p => p.TerritoryName).MaximumLength(50);
        RuleFor(p => p.TerritoryGroup).MaximumLength(50);
        #endregion
    }

}
