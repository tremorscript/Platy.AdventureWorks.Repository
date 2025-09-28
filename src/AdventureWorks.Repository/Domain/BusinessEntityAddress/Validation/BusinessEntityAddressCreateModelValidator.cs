using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BusinessEntityAddressCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityAddressCreateModel>>]
public partial class BusinessEntityAddressCreateModelValidator
    : AbstractValidator<BusinessEntityAddressCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityAddressCreateModelValidator"/> class.
    /// </summary>
    public BusinessEntityAddressCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
