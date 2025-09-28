using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductListPriceHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductListPriceHistoryUpdateModel>>]
public partial class ProductListPriceHistoryUpdateModelValidator
    : AbstractValidator<ProductListPriceHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListPriceHistoryUpdateModelValidator"/> class.
    /// </summary>
    public ProductListPriceHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
