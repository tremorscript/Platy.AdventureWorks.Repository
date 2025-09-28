using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SpecialOfferProduct"/> .
/// </summary>
public partial class SpecialOfferProductProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProductProfile"/> class.
    /// </summary>
    public SpecialOfferProductProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, AdventureWorks.Repository.Domain.Models.SpecialOfferProductReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SpecialOfferProductCreateModel, AdventureWorks.Repository.Data.Entities.SpecialOfferProduct>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, AdventureWorks.Repository.Domain.Models.SpecialOfferProductCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, AdventureWorks.Repository.Domain.Models.SpecialOfferProductUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SpecialOfferProductUpdateModel, AdventureWorks.Repository.Data.Entities.SpecialOfferProduct>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SpecialOfferProductReadModel, AdventureWorks.Repository.Domain.Models.SpecialOfferProductUpdateModel>();

    }

}
