using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesOrderHeaderSalesReasonCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesOrderHeaderSalesReasonCreateModel>>]
public partial class SalesOrderHeaderSalesReasonCreateModelValidator
    : AbstractValidator<SalesOrderHeaderSalesReasonCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonCreateModelValidator"/> class.
    /// </summary>
    public SalesOrderHeaderSalesReasonCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
