using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="JobCandidateCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<JobCandidateCreateModel>>]
public partial class JobCandidateCreateModelValidator
    : AbstractValidator<JobCandidateCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobCandidateCreateModelValidator"/> class.
    /// </summary>
    public JobCandidateCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
