using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CurrencyRate"/> .
/// </summary>
public partial class CurrencyRateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRateProfile"/> class.
    /// </summary>
    public CurrencyRateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.CurrencyRate, AdventureWorks.Repository.Domain.Models.CurrencyRateReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CurrencyRateCreateModel, AdventureWorks.Repository.Data.Entities.CurrencyRate>();

        CreateMap<AdventureWorks.Repository.Data.Entities.CurrencyRate, AdventureWorks.Repository.Domain.Models.CurrencyRateCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.CurrencyRate, AdventureWorks.Repository.Domain.Models.CurrencyRateUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CurrencyRateUpdateModel, AdventureWorks.Repository.Data.Entities.CurrencyRate>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CurrencyRateReadModel, AdventureWorks.Repository.Domain.Models.CurrencyRateUpdateModel>();

    }

}
