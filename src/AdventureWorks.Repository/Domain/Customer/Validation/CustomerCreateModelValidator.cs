using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="CustomerCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<CustomerCreateModel>>]
public partial class CustomerCreateModelValidator
    : AbstractValidator<CustomerCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerCreateModelValidator"/> class.
    /// </summary>
    public CustomerCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
