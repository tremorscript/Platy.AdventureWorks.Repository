using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmployeeDepartmentHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmployeeDepartmentHistoryUpdateModel>>]
public partial class EmployeeDepartmentHistoryUpdateModelValidator
    : AbstractValidator<EmployeeDepartmentHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeDepartmentHistoryUpdateModelValidator"/> class.
    /// </summary>
    public EmployeeDepartmentHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
