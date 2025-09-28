using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductProductPhotoUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductProductPhotoUpdateModel>>]
public partial class ProductProductPhotoUpdateModelValidator
    : AbstractValidator<ProductProductPhotoUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProductPhotoUpdateModelValidator"/> class.
    /// </summary>
    public ProductProductPhotoUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
