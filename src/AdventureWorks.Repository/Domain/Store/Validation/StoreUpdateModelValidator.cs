using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="StoreUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<StoreUpdateModel>>]
public partial class StoreUpdateModelValidator
    : AbstractValidator<StoreUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StoreUpdateModelValidator"/> class.
    /// </summary>
    public StoreUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
