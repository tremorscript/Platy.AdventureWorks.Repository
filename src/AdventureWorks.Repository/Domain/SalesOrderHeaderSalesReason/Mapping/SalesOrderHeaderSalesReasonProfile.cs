using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderHeaderSalesReason"/> .
/// </summary>
public partial class SalesOrderHeaderSalesReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonProfile"/> class.
    /// </summary>
    public SalesOrderHeaderSalesReasonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonCreateModel, AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonUpdateModel, AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonReadModel, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderSalesReasonUpdateModel>();

    }

}
