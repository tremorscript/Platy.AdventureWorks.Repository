using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="AddressTypeCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<AddressTypeCreateModel>>]
public partial class AddressTypeCreateModelValidator
    : AbstractValidator<AddressTypeCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressTypeCreateModelValidator"/> class.
    /// </summary>
    public AddressTypeCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
