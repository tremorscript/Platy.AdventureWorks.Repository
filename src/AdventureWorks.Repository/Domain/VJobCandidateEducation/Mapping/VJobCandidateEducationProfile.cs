using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidateEducation"/> .
/// </summary>
public partial class VJobCandidateEducationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEducationProfile"/> class.
    /// </summary>
    public VJobCandidateEducationProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEducation, AdventureWorks.Repository.Domain.Models.VJobCandidateEducationReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateEducationCreateModel, AdventureWorks.Repository.Data.Entities.VJobCandidateEducation>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEducation, AdventureWorks.Repository.Domain.Models.VJobCandidateEducationCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEducation, AdventureWorks.Repository.Domain.Models.VJobCandidateEducationUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateEducationUpdateModel, AdventureWorks.Repository.Data.Entities.VJobCandidateEducation>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateEducationReadModel, AdventureWorks.Repository.Domain.Models.VJobCandidateEducationUpdateModel>();

    }

}
