using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidateEmployment"/> .
/// </summary>
public partial class VJobCandidateEmploymentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEmploymentProfile"/> class.
    /// </summary>
    public VJobCandidateEmploymentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentCreateModel, AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentUpdateModel, AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentReadModel, AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentUpdateModel>();

    }

}
