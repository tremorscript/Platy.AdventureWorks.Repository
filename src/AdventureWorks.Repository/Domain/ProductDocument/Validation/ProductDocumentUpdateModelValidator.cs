using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductDocumentUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductDocumentUpdateModel>>]
public partial class ProductDocumentUpdateModelValidator
    : AbstractValidator<ProductDocumentUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDocumentUpdateModelValidator"/> class.
    /// </summary>
    public ProductDocumentUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
