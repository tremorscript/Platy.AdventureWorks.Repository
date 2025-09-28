using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderHeader"/> .
/// </summary>
public partial class SalesOrderHeaderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderProfile"/> class.
    /// </summary>
    public SalesOrderHeaderProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeader, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderHeaderCreateModel, AdventureWorks.Repository.Data.Entities.SalesOrderHeader>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeader, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeader, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderHeaderUpdateModel, AdventureWorks.Repository.Data.Entities.SalesOrderHeader>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderHeaderReadModel, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderUpdateModel>();

    }

}
