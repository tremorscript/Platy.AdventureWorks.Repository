using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ShipMethodUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ShipMethodUpdateModel>>]
public partial class ShipMethodUpdateModelValidator
    : AbstractValidator<ShipMethodUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodUpdateModelValidator"/> class.
    /// </summary>
    public ShipMethodUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
