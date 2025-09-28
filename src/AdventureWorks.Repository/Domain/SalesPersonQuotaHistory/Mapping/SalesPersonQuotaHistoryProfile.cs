using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesPersonQuotaHistory"/> .
/// </summary>
public partial class SalesPersonQuotaHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonQuotaHistoryProfile"/> class.
    /// </summary>
    public SalesPersonQuotaHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory, AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryCreateModel, AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory, AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory, AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryReadModel, AdventureWorks.Repository.Domain.Models.SalesPersonQuotaHistoryUpdateModel>();

    }

}
