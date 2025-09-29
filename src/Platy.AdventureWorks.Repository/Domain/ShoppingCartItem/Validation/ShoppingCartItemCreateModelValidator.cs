using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

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
        RuleFor(p => p.ShoppingCartID).NotEmpty();
        RuleFor(p => p.ShoppingCartID).MaximumLength(50);
        #endregion
    }

}
