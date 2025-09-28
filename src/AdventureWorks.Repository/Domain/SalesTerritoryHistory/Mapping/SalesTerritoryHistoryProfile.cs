using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTerritoryHistory"/> .
/// </summary>
public partial class SalesTerritoryHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryHistoryProfile"/> class.
    /// </summary>
    public SalesTerritoryHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory, AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryCreateModel, AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory, AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory, AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.SalesTerritoryHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryReadModel, AdventureWorks.Repository.Domain.Models.SalesTerritoryHistoryUpdateModel>();

    }

}
