using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VIndividualCustomer"/> .
/// </summary>
public partial class VIndividualCustomerProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VIndividualCustomerProfile"/> class.
    /// </summary>
    public VIndividualCustomerProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VIndividualCustomer, AdventureWorks.Repository.Domain.Models.VIndividualCustomerReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VIndividualCustomerCreateModel, AdventureWorks.Repository.Data.Entities.VIndividualCustomer>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VIndividualCustomer, AdventureWorks.Repository.Domain.Models.VIndividualCustomerCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VIndividualCustomer, AdventureWorks.Repository.Domain.Models.VIndividualCustomerUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VIndividualCustomerUpdateModel, AdventureWorks.Repository.Data.Entities.VIndividualCustomer>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VIndividualCustomerReadModel, AdventureWorks.Repository.Domain.Models.VIndividualCustomerUpdateModel>();

    }

}
