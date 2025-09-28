using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductModelIllustrationCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelIllustrationCreateModel>>]
public partial class ProductModelIllustrationCreateModelValidator
    : AbstractValidator<ProductModelIllustrationCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelIllustrationCreateModelValidator"/> class.
    /// </summary>
    public ProductModelIllustrationCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
