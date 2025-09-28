using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmployeePayHistoryCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmployeePayHistoryCreateModel>>]
public partial class EmployeePayHistoryCreateModelValidator
    : AbstractValidator<EmployeePayHistoryCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePayHistoryCreateModelValidator"/> class.
    /// </summary>
    public EmployeePayHistoryCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
