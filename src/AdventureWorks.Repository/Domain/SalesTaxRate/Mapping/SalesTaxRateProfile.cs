using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTaxRate"/> .
/// </summary>
public partial class SalesTaxRateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTaxRateProfile"/> class.
    /// </summary>
    public SalesTaxRateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTaxRate, AdventureWorks.Repository.Domain.Models.SalesTaxRateReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesTaxRateCreateModel, AdventureWorks.Repository.Data.Entities.SalesTaxRate>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTaxRate, AdventureWorks.Repository.Domain.Models.SalesTaxRateCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTaxRate, AdventureWorks.Repository.Domain.Models.SalesTaxRateUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesTaxRateUpdateModel, AdventureWorks.Repository.Data.Entities.SalesTaxRate>();

        CreateMap<AdventureWorks.Repository.Domain.Models.SalesTaxRateReadModel, AdventureWorks.Repository.Domain.Models.SalesTaxRateUpdateModel>();

    }

}
