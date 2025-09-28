using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="VJobCandidateEmploymentUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<VJobCandidateEmploymentUpdateModel>>]
public partial class VJobCandidateEmploymentUpdateModelValidator
    : AbstractValidator<VJobCandidateEmploymentUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEmploymentUpdateModelValidator"/> class.
    /// </summary>
    public VJobCandidateEmploymentUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.EmpOrgName).MaximumLength(100);
        RuleFor(p => p.EmpJobTitle).MaximumLength(100);
        #endregion
    }

}
