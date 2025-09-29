using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CultureCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CultureCreateModel>>]
public partial class CultureCreateModelValidator
    : AbstractValidator<CultureCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CultureCreateModelValidator"/> class.
    /// </summary>
    public CultureCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CultureID).NotEmpty();
        RuleFor(p => p.CultureID).MaximumLength(6);
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
