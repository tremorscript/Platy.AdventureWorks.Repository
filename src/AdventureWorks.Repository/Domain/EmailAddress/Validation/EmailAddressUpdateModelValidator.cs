using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmailAddressUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmailAddressUpdateModel>>]
public partial class EmailAddressUpdateModelValidator
    : AbstractValidator<EmailAddressUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAddressUpdateModelValidator"/> class.
    /// </summary>
    public EmailAddressUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.EmailAddressMember).MaximumLength(50);
        #endregion
    }

}
