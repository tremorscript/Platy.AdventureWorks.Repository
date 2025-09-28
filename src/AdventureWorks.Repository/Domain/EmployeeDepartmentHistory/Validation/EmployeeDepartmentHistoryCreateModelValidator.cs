using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmployeeDepartmentHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmployeeDepartmentHistoryCreateModel>>]
public partial class EmployeeDepartmentHistoryCreateModelValidator
    : AbstractValidator<EmployeeDepartmentHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeDepartmentHistoryCreateModelValidator"/> class.
    /// </summary>
    public EmployeeDepartmentHistoryCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
