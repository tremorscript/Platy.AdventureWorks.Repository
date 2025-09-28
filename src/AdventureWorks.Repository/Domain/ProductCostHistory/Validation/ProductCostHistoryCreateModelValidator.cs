using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductCostHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductCostHistoryCreateModel>>]
public partial class ProductCostHistoryCreateModelValidator
    : AbstractValidator<ProductCostHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCostHistoryCreateModelValidator"/> class.
    /// </summary>
    public ProductCostHistoryCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
