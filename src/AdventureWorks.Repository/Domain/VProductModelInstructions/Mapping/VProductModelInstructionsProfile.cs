using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductModelInstructions"/> .
/// </summary>
public partial class VProductModelInstructionsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelInstructionsProfile"/> class.
    /// </summary>
    public VProductModelInstructionsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelInstructions, AdventureWorks.Repository.Domain.Models.VProductModelInstructionsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductModelInstructionsCreateModel, AdventureWorks.Repository.Data.Entities.VProductModelInstructions>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelInstructions, AdventureWorks.Repository.Domain.Models.VProductModelInstructionsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelInstructions, AdventureWorks.Repository.Domain.Models.VProductModelInstructionsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductModelInstructionsUpdateModel, AdventureWorks.Repository.Data.Entities.VProductModelInstructions>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductModelInstructionsReadModel, AdventureWorks.Repository.Domain.Models.VProductModelInstructionsUpdateModel>();

    }

}
