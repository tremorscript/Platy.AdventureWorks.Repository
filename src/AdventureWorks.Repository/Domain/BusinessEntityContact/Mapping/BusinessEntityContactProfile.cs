using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BusinessEntityContact"/> .
/// </summary>
public partial class BusinessEntityContactProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityContactProfile"/> class.
    /// </summary>
    public BusinessEntityContactProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntityContact, AdventureWorks.Repository.Domain.Models.BusinessEntityContactReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BusinessEntityContactCreateModel, AdventureWorks.Repository.Data.Entities.BusinessEntityContact>();

        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntityContact, AdventureWorks.Repository.Domain.Models.BusinessEntityContactCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntityContact, AdventureWorks.Repository.Domain.Models.BusinessEntityContactUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BusinessEntityContactUpdateModel, AdventureWorks.Repository.Data.Entities.BusinessEntityContact>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BusinessEntityContactReadModel, AdventureWorks.Repository.Domain.Models.BusinessEntityContactUpdateModel>();

    }

}
