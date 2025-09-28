using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesPersonCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesPersonCreateModel>>]
public partial class SalesPersonCreateModelValidator
    : AbstractValidator<SalesPersonCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonCreateModelValidator"/> class.
    /// </summary>
    public SalesPersonCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
