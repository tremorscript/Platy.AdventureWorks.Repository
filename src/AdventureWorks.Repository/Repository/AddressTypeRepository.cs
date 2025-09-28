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
/// Repository class representing data for table 'AddressType'.
/// </summary>
public class AddressTypeRepository
    : EntityRepository<AddressTypeReadModel, AddressTypeCreateModel, AddressTypeUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressTypeRepository"/> class.
    /// </summary>
    public AddressTypeRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<AddressTypeRepository> logger,
        IValidator<AddressTypeCreateModel> createValidator,
        IValidator<AddressTypeUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="AddressTypeReadModel" />.
    /// </summary>
    public async Task<Result<AddressTypeReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<AddressType, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="AddressTypeReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<AddressTypeReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<AddressType,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="AddressType" />.
    /// </summary>
     public async Task<Result<AddressTypeReadModel>> CreateAsync(AddressTypeCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<AddressType, AddressTypeCreatedEvent, int>(createModel,
         new AddressTypeCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="AddressType" />.
    /// </summary>
     public async Task<Result<AddressTypeReadModel>> Update(int id,
       AddressTypeUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<AddressType, AddressTypeUpdatedEvent, int>(id,
         updateModel,
         new AddressTypeUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="AddressType" />.
    /// </summary>
      public virtual async Task<Result<AddressTypeReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<AddressType, AddressTypeDeletedEvent, int>(id,
         new AddressTypeDeletedEvent(),
         cancellationToken);

    #endregion
}
