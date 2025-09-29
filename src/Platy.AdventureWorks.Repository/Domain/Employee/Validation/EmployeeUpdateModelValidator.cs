using System;

using FluentValidation;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="EmployeeUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<EmployeeUpdateModel>>]
public partial class EmployeeUpdateModelValidator
    : AbstractValidator<EmployeeUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeUpdateModelValidator"/> class.
    /// </summary>
    public EmployeeUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.NationalIDNumber).NotEmpty();
        RuleFor(p => p.NationalIDNumber).MaximumLength(15);
        RuleFor(p => p.LoginID).NotEmpty();
        RuleFor(p => p.LoginID).MaximumLength(256);
        RuleFor(p => p.JobTitle).NotEmpty();
        RuleFor(p => p.JobTitle).MaximumLength(50);
        RuleFor(p => p.MaritalStatus).NotEmpty();
        RuleFor(p => p.MaritalStatus).MaximumLength(1);
        RuleFor(p => p.Gender).NotEmpty();
        RuleFor(p => p.Gender).MaximumLength(1);
        #endregion
    }

}
