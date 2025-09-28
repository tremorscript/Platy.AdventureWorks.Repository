using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderDetail"/> .
/// </summary>
public partial class SalesOrderDetailProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetailProfile"/> class.
    /// </summary>
    public SalesOrderDetailProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderDetail, AdventureWorks.Repository.Domain.Models.SalesOrderDetailReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderDetailCreateModel, AdventureWorks.Repository.Data.Entities.SalesOrderDetail>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderDetail, AdventureWorks.Repository.Domain.Models.SalesOrderDetailCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderDetail, AdventureWorks.Repository.Domain.Models.SalesOrderDetailUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderDetailUpdateModel, AdventureWorks.Repository.Data.Entities.SalesOrderDetail>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderDetailReadModel, AdventureWorks.Repository.Domain.Models.SalesOrderDetailUpdateModel>();

    }

}
