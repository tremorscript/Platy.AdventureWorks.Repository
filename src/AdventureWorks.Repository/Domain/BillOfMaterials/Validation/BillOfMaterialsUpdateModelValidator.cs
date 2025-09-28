using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BillOfMaterialsUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BillOfMaterialsUpdateModel>>]
public partial class BillOfMaterialsUpdateModelValidator
    : AbstractValidator<BillOfMaterialsUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsUpdateModelValidator"/> class.
    /// </summary>
    public BillOfMaterialsUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.UnitMeasureCode).NotEmpty();
        RuleFor(p => p.UnitMeasureCode).MaximumLength(3);
        #endregion
    }

}
