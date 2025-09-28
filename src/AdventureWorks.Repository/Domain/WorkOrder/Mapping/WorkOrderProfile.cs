using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="WorkOrder"/> .
/// </summary>
public partial class WorkOrderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderProfile"/> class.
    /// </summary>
    public WorkOrderProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrder, AdventureWorks.Repository.Domain.Models.WorkOrderReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.WorkOrderCreateModel, AdventureWorks.Repository.Data.Entities.WorkOrder>();

        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrder, AdventureWorks.Repository.Domain.Models.WorkOrderCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrder, AdventureWorks.Repository.Domain.Models.WorkOrderUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.WorkOrderUpdateModel, AdventureWorks.Repository.Data.Entities.WorkOrder>();

        CreateMap<AdventureWorks.Repository.Domain.Models.WorkOrderReadModel, AdventureWorks.Repository.Domain.Models.WorkOrderUpdateModel>();

    }

}
