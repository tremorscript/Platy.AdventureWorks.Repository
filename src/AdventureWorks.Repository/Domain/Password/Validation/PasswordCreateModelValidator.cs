using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PasswordCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PasswordCreateModel>>]
public partial class PasswordCreateModelValidator
    : AbstractValidator<PasswordCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordCreateModelValidator"/> class.
    /// </summary>
    public PasswordCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.PasswordHash).NotEmpty();
        RuleFor(p => p.PasswordHash).MaximumLength(128);
        RuleFor(p => p.PasswordSalt).NotEmpty();
        RuleFor(p => p.PasswordSalt).MaximumLength(10);
        #endregion
    }

}
