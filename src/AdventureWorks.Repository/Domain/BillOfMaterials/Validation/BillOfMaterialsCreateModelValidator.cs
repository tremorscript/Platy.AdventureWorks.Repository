using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="BillOfMaterialsCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<BillOfMaterialsCreateModel>>]
public partial class BillOfMaterialsCreateModelValidator
    : AbstractValidator<BillOfMaterialsCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsCreateModelValidator"/> class.
    /// </summary>
    public BillOfMaterialsCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.UnitMeasureCode).NotEmpty();
        RuleFor(p => p.UnitMeasureCode).MaximumLength(3);
        #endregion
    }

}
