using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesOrderDetailCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderDetailCreateModel>>]
public partial class SalesOrderDetailCreateModelValidator
    : AbstractValidator<SalesOrderDetailCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetailCreateModelValidator"/> class.
    /// </summary>
    public SalesOrderDetailCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.CarrierTrackingNumber).MaximumLength(25);
        #endregion
    }

}
