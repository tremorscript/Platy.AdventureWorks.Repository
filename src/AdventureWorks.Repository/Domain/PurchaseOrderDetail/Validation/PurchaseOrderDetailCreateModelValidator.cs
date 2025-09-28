using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PurchaseOrderDetailCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderDetailCreateModel>>]
public partial class PurchaseOrderDetailCreateModelValidator
    : AbstractValidator<PurchaseOrderDetailCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderDetailCreateModelValidator"/> class.
    /// </summary>
    public PurchaseOrderDetailCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
