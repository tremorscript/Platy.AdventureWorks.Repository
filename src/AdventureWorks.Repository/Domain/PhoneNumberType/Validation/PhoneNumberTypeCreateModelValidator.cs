using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PhoneNumberTypeCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PhoneNumberTypeCreateModel>>]
public partial class PhoneNumberTypeCreateModelValidator
    : AbstractValidator<PhoneNumberTypeCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneNumberTypeCreateModelValidator"/> class.
    /// </summary>
    public PhoneNumberTypeCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
