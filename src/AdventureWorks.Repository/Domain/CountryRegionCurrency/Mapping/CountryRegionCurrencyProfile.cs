using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CountryRegionCurrency"/> .
/// </summary>
public partial class CountryRegionCurrencyProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionCurrencyProfile"/> class.
    /// </summary>
    public CountryRegionCurrencyProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.CountryRegionCurrency, AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyCreateModel, AdventureWorks.Repository.Data.Entities.CountryRegionCurrency>();

        CreateMap<AdventureWorks.Repository.Data.Entities.CountryRegionCurrency, AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.CountryRegionCurrency, AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyUpdateModel, AdventureWorks.Repository.Data.Entities.CountryRegionCurrency>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyReadModel, AdventureWorks.Repository.Domain.Models.CountryRegionCurrencyUpdateModel>();

    }

}
