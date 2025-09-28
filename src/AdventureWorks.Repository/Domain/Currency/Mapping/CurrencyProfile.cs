using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Currency"/> .
/// </summary>
public partial class CurrencyProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyProfile"/> class.
    /// </summary>
    public CurrencyProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Currency, AdventureWorks.Repository.Domain.Models.CurrencyReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CurrencyCreateModel, AdventureWorks.Repository.Data.Entities.Currency>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Currency, AdventureWorks.Repository.Domain.Models.CurrencyCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Currency, AdventureWorks.Repository.Domain.Models.CurrencyUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CurrencyUpdateModel, AdventureWorks.Repository.Data.Entities.Currency>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CurrencyReadModel, AdventureWorks.Repository.Domain.Models.CurrencyUpdateModel>();

    }

}
