using System;
using System.Collections.Generic;

using AdventureWorks.Repository.BaseRepository;
using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;
using AdventureWorks.Repository.Events;
using FluentValidation;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using MediatR;
namespace AdventureWorks.Repository;

/// <summary>
/// Repository class representing data for table 'Customer'.
/// </summary>
public class CustomerRepository
    : EntityRepository<CustomerReadModel, CustomerCreateModel, CustomerUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
    /// </summary>
    public CustomerRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<CustomerRepository> logger,
        IValidator<CustomerCreateModel> createValidator,
        IValidator<CustomerUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="CustomerReadModel" />.
    /// </summary>
    public async Task<Result<CustomerReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<Customer, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="CustomerReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<CustomerReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Customer,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Customer" />.
    /// </summary>
     public async Task<Result<CustomerReadModel>> CreateAsync(CustomerCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Customer, CustomerCreatedEvent, int>(createModel,
         new CustomerCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Customer" />.
    /// </summary>
     public async Task<Result<CustomerReadModel>> Update(int id,
       CustomerUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Customer, CustomerUpdatedEvent, int>(id,
         updateModel,
         new CustomerUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Customer" />.
    /// </summary>
      public virtual async Task<Result<CustomerReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Customer, CustomerDeletedEvent, int>(id,
         new CustomerDeletedEvent(),
         cancellationToken);

    #endregion
}
