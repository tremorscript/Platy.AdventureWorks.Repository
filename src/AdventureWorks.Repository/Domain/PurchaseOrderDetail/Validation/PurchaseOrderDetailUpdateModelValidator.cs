using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PurchaseOrderDetailUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderDetailUpdateModel>>]
public partial class PurchaseOrderDetailUpdateModelValidator
    : AbstractValidator<PurchaseOrderDetailUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderDetailUpdateModelValidator"/> class.
    /// </summary>
    public PurchaseOrderDetailUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
