using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="JobCandidate"/> .
/// </summary>
public partial class JobCandidateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobCandidateProfile"/> class.
    /// </summary>
    public JobCandidateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.JobCandidate, AdventureWorks.Repository.Domain.Models.JobCandidateReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.JobCandidateCreateModel, AdventureWorks.Repository.Data.Entities.JobCandidate>();

        CreateMap<AdventureWorks.Repository.Data.Entities.JobCandidate, AdventureWorks.Repository.Domain.Models.JobCandidateCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.JobCandidate, AdventureWorks.Repository.Domain.Models.JobCandidateUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.JobCandidateUpdateModel, AdventureWorks.Repository.Data.Entities.JobCandidate>();

        CreateMap<AdventureWorks.Repository.Domain.Models.JobCandidateReadModel, AdventureWorks.Repository.Domain.Models.JobCandidateUpdateModel>();

    }

}
