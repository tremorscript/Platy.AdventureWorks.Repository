using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VAdditionalContactInfoUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VAdditionalContactInfoUpdateModel>>]
public partial class VAdditionalContactInfoUpdateModelValidator
    : AbstractValidator<VAdditionalContactInfoUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VAdditionalContactInfoUpdateModelValidator"/> class.
    /// </summary>
    public VAdditionalContactInfoUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.FirstName).NotEmpty();
        RuleFor(p => p.FirstName).MaximumLength(50);
        RuleFor(p => p.MiddleName).MaximumLength(50);
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.LastName).MaximumLength(50);
        RuleFor(p => p.TelephoneNumber).MaximumLength(50);
        RuleFor(p => p.Street).MaximumLength(50);
        RuleFor(p => p.City).MaximumLength(50);
        RuleFor(p => p.StateProvince).MaximumLength(50);
        RuleFor(p => p.PostalCode).MaximumLength(50);
        RuleFor(p => p.CountryRegion).MaximumLength(50);
        RuleFor(p => p.EMailAddress).MaximumLength(128);
        RuleFor(p => p.EMailTelephoneNumber).MaximumLength(50);
        #endregion
    }

}
