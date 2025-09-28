using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="TransactionHistoryArchiveCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<TransactionHistoryArchiveCreateModel>>]
public partial class TransactionHistoryArchiveCreateModelValidator
    : AbstractValidator<TransactionHistoryArchiveCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryArchiveCreateModelValidator"/> class.
    /// </summary>
    public TransactionHistoryArchiveCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.TransactionType).NotEmpty();
        RuleFor(p => p.TransactionType).MaximumLength(1);
        #endregion
    }

}
