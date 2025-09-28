using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Password"/> .
/// </summary>
public partial class PasswordProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordProfile"/> class.
    /// </summary>
    public PasswordProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Password, AdventureWorks.Repository.Domain.Models.PasswordReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PasswordCreateModel, AdventureWorks.Repository.Data.Entities.Password>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Password, AdventureWorks.Repository.Domain.Models.PasswordCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Password, AdventureWorks.Repository.Domain.Models.PasswordUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PasswordUpdateModel, AdventureWorks.Repository.Data.Entities.Password>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PasswordReadModel, AdventureWorks.Repository.Domain.Models.PasswordUpdateModel>();

    }

}
