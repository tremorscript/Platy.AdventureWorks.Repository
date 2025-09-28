using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmailAddressCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmailAddressCreateModel>>]
public partial class EmailAddressCreateModelValidator
    : AbstractValidator<EmailAddressCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAddressCreateModelValidator"/> class.
    /// </summary>
    public EmailAddressCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.EmailAddressMember).MaximumLength(50);
        #endregion
    }

}
