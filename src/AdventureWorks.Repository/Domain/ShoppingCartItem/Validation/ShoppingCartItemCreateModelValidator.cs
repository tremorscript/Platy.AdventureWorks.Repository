using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ShoppingCartItemCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ShoppingCartItemCreateModel>>]
public partial class ShoppingCartItemCreateModelValidator
    : AbstractValidator<ShoppingCartItemCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShoppingCartItemCreateModelValidator"/> class.
    /// </summary>
    public ShoppingCartItemCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.ShoppingCartId).NotEmpty();
        RuleFor(p => p.ShoppingCartId).MaximumLength(50);
        #endregion
    }

}
