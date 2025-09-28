using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidate"/> .
/// </summary>
public partial class VJobCandidateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateProfile"/> class.
    /// </summary>
    public VJobCandidateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidate, AdventureWorks.Repository.Domain.Models.VJobCandidateReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateCreateModel, AdventureWorks.Repository.Data.Entities.VJobCandidate>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidate, AdventureWorks.Repository.Domain.Models.VJobCandidateCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidate, AdventureWorks.Repository.Domain.Models.VJobCandidateUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateUpdateModel, AdventureWorks.Repository.Data.Entities.VJobCandidate>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateReadModel, AdventureWorks.Repository.Domain.Models.VJobCandidateUpdateModel>();

    }

}
