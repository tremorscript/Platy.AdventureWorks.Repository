using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CultureUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CultureUpdateModel>>]
public partial class CultureUpdateModelValidator
    : AbstractValidator<CultureUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CultureUpdateModelValidator"/> class.
    /// </summary>
    public CultureUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CultureID).NotEmpty();
        RuleFor(p => p.CultureID).MaximumLength(6);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
