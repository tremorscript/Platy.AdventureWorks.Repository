using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CustomerUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CustomerUpdateModel>>]
public partial class CustomerUpdateModelValidator
    : AbstractValidator<CustomerUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerUpdateModelValidator"/> class.
    /// </summary>
    public CustomerUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
