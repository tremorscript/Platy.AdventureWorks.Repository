using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BusinessEntityAddressUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BusinessEntityAddressUpdateModel>>]
public partial class BusinessEntityAddressUpdateModelValidator
    : AbstractValidator<BusinessEntityAddressUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityAddressUpdateModelValidator"/> class.
    /// </summary>
    public BusinessEntityAddressUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
