using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PersonCreditCardCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PersonCreditCardCreateModel>>]
public partial class PersonCreditCardCreateModelValidator
    : AbstractValidator<PersonCreditCardCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonCreditCardCreateModelValidator"/> class.
    /// </summary>
    public PersonCreditCardCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
