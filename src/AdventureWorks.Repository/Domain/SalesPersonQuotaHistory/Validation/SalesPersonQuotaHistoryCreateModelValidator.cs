using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesPersonQuotaHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesPersonQuotaHistoryCreateModel>>]
public partial class SalesPersonQuotaHistoryCreateModelValidator
    : AbstractValidator<SalesPersonQuotaHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonQuotaHistoryCreateModelValidator"/> class.
    /// </summary>
    public SalesPersonQuotaHistoryCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
