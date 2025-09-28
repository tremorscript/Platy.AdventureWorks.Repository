using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VJobCandidateEmploymentCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VJobCandidateEmploymentCreateModel>>]
public partial class VJobCandidateEmploymentCreateModelValidator
    : AbstractValidator<VJobCandidateEmploymentCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEmploymentCreateModelValidator"/> class.
    /// </summary>
    public VJobCandidateEmploymentCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.EmpOrgName).MaximumLength(100);
        RuleFor(p => p.EmpJobTitle).MaximumLength(100);
        #endregion
    }

}
