using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="WorkOrderRoutingCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<WorkOrderRoutingCreateModel>>]
public partial class WorkOrderRoutingCreateModelValidator
    : AbstractValidator<WorkOrderRoutingCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderRoutingCreateModelValidator"/> class.
    /// </summary>
    public WorkOrderRoutingCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
