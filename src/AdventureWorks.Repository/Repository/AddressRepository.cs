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
/// Repository class representing data for table 'Address'.
/// </summary>
public class AddressRepository
    : EntityRepository<AddressReadModel, AddressCreateModel, AddressUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressRepository"/> class.
    /// </summary>
    public AddressRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<AddressRepository> logger,
        IValidator<AddressCreateModel> createValidator,
        IValidator<AddressUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="AddressReadModel" />.
    /// </summary>
    public async Task<Result<AddressReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<Address, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="AddressReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<AddressReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Address,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Address" />.
    /// </summary>
     public async Task<Result<AddressReadModel>> CreateAsync(AddressCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Address, AddressCreatedEvent, int>(createModel,
         new AddressCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Address" />.
    /// </summary>
     public async Task<Result<AddressReadModel>> Update(int id,
       AddressUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Address, AddressUpdatedEvent, int>(id,
         updateModel,
         new AddressUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Address" />.
    /// </summary>
      public virtual async Task<Result<AddressReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Address, AddressDeletedEvent, int>(id,
         new AddressDeletedEvent(),
         cancellationToken);

    #endregion
}
