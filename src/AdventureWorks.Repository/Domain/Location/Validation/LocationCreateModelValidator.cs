using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="LocationCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<LocationCreateModel>>]
public partial class LocationCreateModelValidator
    : AbstractValidator<LocationCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationCreateModelValidator"/> class.
    /// </summary>
    public LocationCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        #endregion
    }

}
