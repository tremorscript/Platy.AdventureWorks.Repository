using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="WorkOrderRouting"/> .
/// </summary>
public partial class WorkOrderRoutingProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderRoutingProfile"/> class.
    /// </summary>
    public WorkOrderRoutingProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrderRouting, AdventureWorks.Repository.Domain.Models.WorkOrderRoutingReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.WorkOrderRoutingCreateModel, AdventureWorks.Repository.Data.Entities.WorkOrderRouting>();

        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrderRouting, AdventureWorks.Repository.Domain.Models.WorkOrderRoutingCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrderRouting, AdventureWorks.Repository.Domain.Models.WorkOrderRoutingUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.WorkOrderRoutingUpdateModel, AdventureWorks.Repository.Data.Entities.WorkOrderRouting>();

        CreateMap<AdventureWorks.Repository.Domain.Models.WorkOrderRoutingReadModel, AdventureWorks.Repository.Domain.Models.WorkOrderRoutingUpdateModel>();

    }

}
