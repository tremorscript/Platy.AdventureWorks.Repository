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
/// Repository class representing data for table 'Location'.
/// </summary>
public class LocationRepository
    : EntityRepository<LocationReadModel, LocationCreateModel, LocationUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationRepository"/> class.
    /// </summary>
    public LocationRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<LocationRepository> logger,
        IValidator<LocationCreateModel> createValidator,
        IValidator<LocationUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="LocationReadModel" />.
    /// </summary>
    public async Task<Result<LocationReadModel>> GetAsync(short id,
      CancellationToken cancellationToken) =>
      await ReadModel<Location, short>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="LocationReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<LocationReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Location,short>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Location" />.
    /// </summary>
     public async Task<Result<LocationReadModel>> CreateAsync(LocationCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Location, LocationCreatedEvent, short>(createModel,
         new LocationCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Location" />.
    /// </summary>
     public async Task<Result<LocationReadModel>> Update(short id,
       LocationUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Location, LocationUpdatedEvent, short>(id,
         updateModel,
         new LocationUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Location" />.
    /// </summary>
      public virtual async Task<Result<LocationReadModel>> Delete(short id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Location, LocationDeletedEvent, short>(id,
         new LocationDeletedEvent(),
         cancellationToken);

    #endregion
}
