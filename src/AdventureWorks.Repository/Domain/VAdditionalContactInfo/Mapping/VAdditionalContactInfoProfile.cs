using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VAdditionalContactInfo"/> .
/// </summary>
public partial class VAdditionalContactInfoProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VAdditionalContactInfoProfile"/> class.
    /// </summary>
    public VAdditionalContactInfoProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo, AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoCreateModel, AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo, AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo, AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoUpdateModel, AdventureWorks.Repository.Data.Entities.VAdditionalContactInfo>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoReadModel, AdventureWorks.Repository.Domain.Models.VAdditionalContactInfoUpdateModel>();

    }

}
