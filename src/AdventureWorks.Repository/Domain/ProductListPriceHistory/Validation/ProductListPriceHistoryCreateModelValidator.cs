using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductListPriceHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductListPriceHistoryCreateModel>>]
public partial class ProductListPriceHistoryCreateModelValidator
    : AbstractValidator<ProductListPriceHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListPriceHistoryCreateModelValidator"/> class.
    /// </summary>
    public ProductListPriceHistoryCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
