using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PurchaseOrderHeaderUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderHeaderUpdateModel>>]
public partial class PurchaseOrderHeaderUpdateModelValidator
    : AbstractValidator<PurchaseOrderHeaderUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderHeaderUpdateModelValidator"/> class.
    /// </summary>
    public PurchaseOrderHeaderUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
