using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="TransactionHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<TransactionHistoryUpdateModel>>]
public partial class TransactionHistoryUpdateModelValidator
    : AbstractValidator<TransactionHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryUpdateModelValidator"/> class.
    /// </summary>
    public TransactionHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.TransactionType).NotEmpty();
        RuleFor(p => p.TransactionType).MaximumLength(1);
        #endregion
    }

}
