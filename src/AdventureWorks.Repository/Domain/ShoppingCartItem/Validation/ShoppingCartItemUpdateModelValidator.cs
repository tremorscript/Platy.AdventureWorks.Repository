using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ShoppingCartItemUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ShoppingCartItemUpdateModel>>]
public partial class ShoppingCartItemUpdateModelValidator
    : AbstractValidator<ShoppingCartItemUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShoppingCartItemUpdateModelValidator"/> class.
    /// </summary>
    public ShoppingCartItemUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.ShoppingCartId).NotEmpty();
        RuleFor(p => p.ShoppingCartId).MaximumLength(50);
        #endregion
    }

}
