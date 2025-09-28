using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesReason"/> .
/// </summary>
public partial class SalesReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesReasonProfile"/> class.
    /// </summary>
    public SalesReasonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesReason, AdventureWorks.Repository.Domain.Models.SalesReasonReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesReasonCreateModel, AdventureWorks.Repository.Data.Entities.SalesReason>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesReason, AdventureWorks.Repository.Domain.Models.SalesReasonCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesReason, AdventureWorks.Repository.Domain.Models.SalesReasonUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesReasonUpdateModel, AdventureWorks.Repository.Data.Entities.SalesReason>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesReasonReadModel, AdventureWorks.Repository.Domain.Models.SalesReasonUpdateModel>();

    }

}
