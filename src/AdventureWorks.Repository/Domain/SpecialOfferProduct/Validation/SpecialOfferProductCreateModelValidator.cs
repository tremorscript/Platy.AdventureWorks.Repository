using System;

using FluentValidation;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Validation;

/// <summary>
/// Validator class for <see cref="SpecialOfferProductCreateModel"/> .
/// </summary>
[RegisterSingleton<IValidator<SpecialOfferProductCreateModel>>]
public partial class SpecialOfferProductCreateModelValidator
    : AbstractValidator<SpecialOfferProductCreateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProductCreateModelValidator"/> class.
    /// </summary>
    public SpecialOfferProductCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
