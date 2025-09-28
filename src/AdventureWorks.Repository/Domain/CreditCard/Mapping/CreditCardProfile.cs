using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CreditCard"/> .
/// </summary>
public partial class CreditCardProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardProfile"/> class.
    /// </summary>
    public CreditCardProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.CreditCard, AdventureWorks.Repository.Domain.Models.CreditCardReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CreditCardCreateModel, AdventureWorks.Repository.Data.Entities.CreditCard>();

        CreateMap<AdventureWorks.Repository.Data.Entities.CreditCard, AdventureWorks.Repository.Domain.Models.CreditCardCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.CreditCard, AdventureWorks.Repository.Domain.Models.CreditCardUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CreditCardUpdateModel, AdventureWorks.Repository.Data.Entities.CreditCard>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CreditCardReadModel, AdventureWorks.Repository.Domain.Models.CreditCardUpdateModel>();

    }

}
