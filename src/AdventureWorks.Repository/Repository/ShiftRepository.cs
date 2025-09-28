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
/// Repository class representing data for table 'Shift'.
/// </summary>
public class ShiftRepository
    : EntityRepository<ShiftReadModel, ShiftCreateModel, ShiftUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftRepository"/> class.
    /// </summary>
    public ShiftRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ShiftRepository> logger,
        IValidator<ShiftCreateModel> createValidator,
        IValidator<ShiftUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ShiftReadModel" />.
    /// </summary>
    public async Task<Result<ShiftReadModel>> GetAsync(byte id,
      CancellationToken cancellationToken) =>
      await ReadModel<Shift, byte>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ShiftReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ShiftReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Shift,byte>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Shift" />.
    /// </summary>
     public async Task<Result<ShiftReadModel>> CreateAsync(ShiftCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Shift, ShiftCreatedEvent, byte>(createModel,
         new ShiftCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Shift" />.
    /// </summary>
     public async Task<Result<ShiftReadModel>> Update(byte id,
       ShiftUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Shift, ShiftUpdatedEvent, byte>(id,
         updateModel,
         new ShiftUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Shift" />.
    /// </summary>
      public virtual async Task<Result<ShiftReadModel>> Delete(byte id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Shift, ShiftDeletedEvent, byte>(id,
         new ShiftDeletedEvent(),
         cancellationToken);

    #endregion
}
