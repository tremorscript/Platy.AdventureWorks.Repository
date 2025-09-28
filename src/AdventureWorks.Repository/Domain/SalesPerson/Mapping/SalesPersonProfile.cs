using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesPerson"/> .
/// </summary>
public partial class SalesPersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonProfile"/> class.
    /// </summary>
    public SalesPersonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPerson, AdventureWorks.Repository.Domain.Models.SalesPersonReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesPersonCreateModel, AdventureWorks.Repository.Data.Entities.SalesPerson>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPerson, AdventureWorks.Repository.Domain.Models.SalesPersonCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPerson, AdventureWorks.Repository.Domain.Models.SalesPersonUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesPersonUpdateModel, AdventureWorks.Repository.Data.Entities.SalesPerson>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesPersonReadModel, AdventureWorks.Repository.Domain.Models.SalesPersonUpdateModel>();

    }

}
