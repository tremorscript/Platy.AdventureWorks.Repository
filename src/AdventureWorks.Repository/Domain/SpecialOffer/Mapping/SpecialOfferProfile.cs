using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SpecialOffer"/> .
/// </summary>
public partial class SpecialOfferProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProfile"/> class.
    /// </summary>
    public SpecialOfferProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOffer, AdventureWorks.Repository.Domain.Models.SpecialOfferReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SpecialOfferCreateModel, AdventureWorks.Repository.Data.Entities.SpecialOffer>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOffer, AdventureWorks.Repository.Domain.Models.SpecialOfferCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOffer, AdventureWorks.Repository.Domain.Models.SpecialOfferUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SpecialOfferUpdateModel, AdventureWorks.Repository.Data.Entities.SpecialOffer>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SpecialOfferReadModel, AdventureWorks.Repository.Domain.Models.SpecialOfferUpdateModel>();

    }

}
