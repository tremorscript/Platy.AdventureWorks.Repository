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
/// Repository class representing data for table 'SalesReason'.
/// </summary>
public class SalesReasonRepository
    : EntityRepository<SalesReasonReadModel, SalesReasonCreateModel, SalesReasonUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesReasonRepository"/> class.
    /// </summary>
    public SalesReasonRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<SalesReasonRepository> logger,
        IValidator<SalesReasonCreateModel> createValidator,
        IValidator<SalesReasonUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="SalesReasonReadModel" />.
    /// </summary>
    public async Task<Result<SalesReasonReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<SalesReason, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="SalesReasonReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<SalesReasonReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<SalesReason,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="SalesReason" />.
    /// </summary>
     public async Task<Result<SalesReasonReadModel>> CreateAsync(SalesReasonCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<SalesReason, SalesReasonCreatedEvent, int>(createModel,
         new SalesReasonCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="SalesReason" />.
    /// </summary>
     public async Task<Result<SalesReasonReadModel>> Update(int id,
       SalesReasonUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<SalesReason, SalesReasonUpdatedEvent, int>(id,
         updateModel,
         new SalesReasonUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="SalesReason" />.
    /// </summary>
      public virtual async Task<Result<SalesReasonReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<SalesReason, SalesReasonDeletedEvent, int>(id,
         new SalesReasonDeletedEvent(),
         cancellationToken);

    #endregion
}
