using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VSalesPersonSalesByFiscalYears"/> .
/// </summary>
public partial class VSalesPersonSalesByFiscalYearsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYearsProfile"/> class.
    /// </summary>
    public VSalesPersonSalesByFiscalYearsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears, AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsCreateModel, AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears, AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears, AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsUpdateModel, AdventureWorks.Repository.Data.Entities.VSalesPersonSalesByFiscalYears>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsReadModel, AdventureWorks.Repository.Domain.Models.VSalesPersonSalesByFiscalYearsUpdateModel>();

    }

}
