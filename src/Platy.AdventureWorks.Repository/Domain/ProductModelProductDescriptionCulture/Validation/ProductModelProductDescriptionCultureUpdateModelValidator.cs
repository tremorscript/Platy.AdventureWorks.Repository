using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductModelProductDescriptionCultureUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelProductDescriptionCultureUpdateModel>>]
public partial class ProductModelProductDescriptionCultureUpdateModelValidator
    : AbstractValidator<ProductModelProductDescriptionCultureUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProductDescriptionCultureUpdateModelValidator"/> class.
    /// </summary>
    public ProductModelProductDescriptionCultureUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CultureID).NotEmpty();
        RuleFor(p => p.CultureID).MaximumLength(6);
        #endregion
    }

}
