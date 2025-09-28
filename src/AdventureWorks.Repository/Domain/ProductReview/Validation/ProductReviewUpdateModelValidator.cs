using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="ProductReviewUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<ProductReviewUpdateModel>>]
public partial class ProductReviewUpdateModelValidator
    : AbstractValidator<ProductReviewUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReviewUpdateModelValidator"/> class.
    /// </summary>
    public ProductReviewUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.ReviewerName).NotEmpty();
        RuleFor(p => p.ReviewerName).MaximumLength(50);
        RuleFor(p => p.EmailAddress).NotEmpty();
        RuleFor(p => p.EmailAddress).MaximumLength(50);
        RuleFor(p => p.Comments).MaximumLength(3850);
        #endregion
    }

}
