using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesPersonUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesPersonUpdateModel>>]
public partial class SalesPersonUpdateModelValidator
    : AbstractValidator<SalesPersonUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonUpdateModelValidator"/> class.
    /// </summary>
    public SalesPersonUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
