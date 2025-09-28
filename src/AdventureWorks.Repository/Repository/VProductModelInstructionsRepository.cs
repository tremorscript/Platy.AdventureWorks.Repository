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
/// Repository class representing data for table 'vProductModelInstructions'.
/// </summary>
public class VProductModelInstructionsRepository
    : EntityRepository<VProductModelInstructionsReadModel, VProductModelInstructionsCreateModel, VProductModelInstructionsUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelInstructionsRepository"/> class.
    /// </summary>
    public VProductModelInstructionsRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VProductModelInstructionsRepository> logger,
        IValidator<VProductModelInstructionsCreateModel> createValidator,
        IValidator<VProductModelInstructionsUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VProductModelInstructionsReadModel" />.
    /// </summary>
    public async Task<Result<VProductModelInstructionsReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VProductModelInstructions, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VProductModelInstructionsReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VProductModelInstructionsReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<VProductModelInstructions,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VProductModelInstructions" />.
    /// </summary>
     public async Task<Result<VProductModelInstructionsReadModel>> CreateAsync(VProductModelInstructionsCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<VProductModelInstructions, VProductModelInstructionsCreatedEvent, int>(createModel,
         new VProductModelInstructionsCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VProductModelInstructions" />.
    /// </summary>
     public async Task<Result<VProductModelInstructionsReadModel>> Update(int id,
       VProductModelInstructionsUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<VProductModelInstructions, VProductModelInstructionsUpdatedEvent, int>(id,
         updateModel,
         new VProductModelInstructionsUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VProductModelInstructions" />.
    /// </summary>
      public virtual async Task<Result<VProductModelInstructionsReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<VProductModelInstructions, VProductModelInstructionsDeletedEvent, int>(id,
         new VProductModelInstructionsDeletedEvent(),
         cancellationToken);

    #endregion
}
