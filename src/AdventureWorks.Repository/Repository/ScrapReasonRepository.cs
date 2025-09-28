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
/// Repository class representing data for table 'ScrapReason'.
/// </summary>
public class ScrapReasonRepository
    : EntityRepository<ScrapReasonReadModel, ScrapReasonCreateModel, ScrapReasonUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrapReasonRepository"/> class.
    /// </summary>
    public ScrapReasonRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ScrapReasonRepository> logger,
        IValidator<ScrapReasonCreateModel> createValidator,
        IValidator<ScrapReasonUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ScrapReasonReadModel" />.
    /// </summary>
    public async Task<Result<ScrapReasonReadModel>> GetAsync(short id,
      CancellationToken cancellationToken) =>
      await ReadModel<ScrapReason, short>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ScrapReasonReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ScrapReasonReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ScrapReason,short>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ScrapReason" />.
    /// </summary>
     public async Task<Result<ScrapReasonReadModel>> CreateAsync(ScrapReasonCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ScrapReason, ScrapReasonCreatedEvent, short>(createModel,
         new ScrapReasonCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ScrapReason" />.
    /// </summary>
     public async Task<Result<ScrapReasonReadModel>> Update(short id,
       ScrapReasonUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ScrapReason, ScrapReasonUpdatedEvent, short>(id,
         updateModel,
         new ScrapReasonUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ScrapReason" />.
    /// </summary>
      public virtual async Task<Result<ScrapReasonReadModel>> Delete(short id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ScrapReason, ScrapReasonDeletedEvent, short>(id,
         new ScrapReasonDeletedEvent(),
         cancellationToken);

    #endregion
}
