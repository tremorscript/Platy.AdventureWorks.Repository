using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductModelProductDescriptionCultureCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductModelProductDescriptionCultureCreateModel>>]
public partial class ProductModelProductDescriptionCultureCreateModelValidator
    : AbstractValidator<ProductModelProductDescriptionCultureCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProductDescriptionCultureCreateModelValidator"/> class.
    /// </summary>
    public ProductModelProductDescriptionCultureCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CultureID).NotEmpty();
        RuleFor(p => p.CultureID).MaximumLength(6);
        #endregion
    }

}
