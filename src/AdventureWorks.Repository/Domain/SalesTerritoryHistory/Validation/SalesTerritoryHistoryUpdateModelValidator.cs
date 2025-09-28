using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SalesTerritoryHistoryUpdateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SalesTerritoryHistoryUpdateModel>>]
public partial class SalesTerritoryHistoryUpdateModelValidator
    : AbstractValidator<SalesTerritoryHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryHistoryUpdateModelValidator"/> class.
    /// </summary>
    public SalesTerritoryHistoryUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
