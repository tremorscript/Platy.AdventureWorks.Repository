using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="PurchaseOrderHeaderCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<PurchaseOrderHeaderCreateModel>>]
public partial class PurchaseOrderHeaderCreateModelValidator
    : AbstractValidator<PurchaseOrderHeaderCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderHeaderCreateModelValidator"/> class.
    /// </summary>
    public PurchaseOrderHeaderCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
