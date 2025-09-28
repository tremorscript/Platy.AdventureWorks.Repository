using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ShipMethod"/> .
/// </summary>
public partial class ShipMethodProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodProfile"/> class.
    /// </summary>
    public ShipMethodProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ShipMethod, AdventureWorks.Repository.Domain.Models.ShipMethodReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ShipMethodCreateModel, AdventureWorks.Repository.Data.Entities.ShipMethod>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ShipMethod, AdventureWorks.Repository.Domain.Models.ShipMethodCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ShipMethod, AdventureWorks.Repository.Domain.Models.ShipMethodUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ShipMethodUpdateModel, AdventureWorks.Repository.Data.Entities.ShipMethod>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ShipMethodReadModel, AdventureWorks.Repository.Domain.Models.ShipMethodUpdateModel>();

    }

}
