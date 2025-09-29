using System;
using System.Collections.Generic;

using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;
using FluentValidation;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;
using MediatR;
namespace Platy.AdventureWorks.Repository;

/// <summary>
/// Repository class representing data for table 'ShipMethod'.
/// </summary>
public class ShipMethodRepository
    : EntityRepository<ShipMethodReadModel, ShipMethodCreateModel, ShipMethodUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodRepository"/> class.
    /// </summary>
    public ShipMethodRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ShipMethodRepository> logger,
        IValidator<ShipMethodCreateModel> createValidator,
        IValidator<ShipMethodUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ShipMethodReadModel" />.
    /// </summary>
    public async Task<Result<ShipMethodReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ShipMethod, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ShipMethodReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ShipMethodReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ShipMethod,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ShipMethod" />.
    /// </summary>
     public async Task<Result<ShipMethodReadModel>> CreateAsync(ShipMethodCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ShipMethod, ShipMethodCreatedEvent, int>(createModel,
         new ShipMethodCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ShipMethod" />.
    /// </summary>
     public async Task<Result<ShipMethodReadModel>> Update(int id,
       ShipMethodUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ShipMethod, ShipMethodUpdatedEvent, int>(id,
         updateModel,
         new ShipMethodUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ShipMethod" />.
    /// </summary>
      public virtual async Task<Result<ShipMethodReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ShipMethod, ShipMethodDeletedEvent, int>(id,
         new ShipMethodDeletedEvent(),
         cancellationToken);

    #endregion
}
