using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BusinessEntityCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityCreateModel>>]
public partial class BusinessEntityCreateModelValidator
    : AbstractValidator<BusinessEntityCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityCreateModelValidator"/> class.
    /// </summary>
    public BusinessEntityCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
