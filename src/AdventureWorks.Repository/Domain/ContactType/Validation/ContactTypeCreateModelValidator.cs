using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ContactTypeCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ContactTypeCreateModel>>]
public partial class ContactTypeCreateModelValidator
    : AbstractValidator<ContactTypeCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactTypeCreateModelValidator"/> class.
    /// </summary>
    public ContactTypeCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
