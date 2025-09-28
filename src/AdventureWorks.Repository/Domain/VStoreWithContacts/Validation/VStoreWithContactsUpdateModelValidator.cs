using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VStoreWithContactsUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VStoreWithContactsUpdateModel>>]
public partial class VStoreWithContactsUpdateModelValidator
    : AbstractValidator<VStoreWithContactsUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithContactsUpdateModelValidator"/> class.
    /// </summary>
    public VStoreWithContactsUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.ContactType).NotEmpty();
        RuleFor(p => p.ContactType).MaximumLength(50);
        RuleFor(p => p.Title).MaximumLength(8);
        RuleFor(p => p.FirstName).NotEmpty();
        RuleFor(p => p.FirstName).MaximumLength(50);
        RuleFor(p => p.MiddleName).MaximumLength(50);
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.LastName).MaximumLength(50);
        RuleFor(p => p.Suffix).MaximumLength(10);
        RuleFor(p => p.PhoneNumber).MaximumLength(25);
        RuleFor(p => p.PhoneNumberType).MaximumLength(50);
        RuleFor(p => p.EmailAddress).MaximumLength(50);
        #endregion
    }

}
