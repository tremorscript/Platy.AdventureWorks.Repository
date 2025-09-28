using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BillOfMaterials"/> .
/// </summary>
public partial class BillOfMaterialsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsProfile"/> class.
    /// </summary>
    public BillOfMaterialsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.BillOfMaterials, AdventureWorks.Repository.Domain.Models.BillOfMaterialsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BillOfMaterialsCreateModel, AdventureWorks.Repository.Data.Entities.BillOfMaterials>();

        CreateMap<AdventureWorks.Repository.Data.Entities.BillOfMaterials, AdventureWorks.Repository.Domain.Models.BillOfMaterialsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.BillOfMaterials, AdventureWorks.Repository.Domain.Models.BillOfMaterialsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BillOfMaterialsUpdateModel, AdventureWorks.Repository.Data.Entities.BillOfMaterials>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BillOfMaterialsReadModel, AdventureWorks.Repository.Domain.Models.BillOfMaterialsUpdateModel>();

    }

}
