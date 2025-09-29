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
/// Repository class representing data for table 'TransactionHistory'.
/// </summary>
public class TransactionHistoryRepository
    : EntityRepository<TransactionHistoryReadModel, TransactionHistoryCreateModel, TransactionHistoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryRepository"/> class.
    /// </summary>
    public TransactionHistoryRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<TransactionHistoryRepository> logger,
        IValidator<TransactionHistoryCreateModel> createValidator,
        IValidator<TransactionHistoryUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="TransactionHistoryReadModel" />.
    /// </summary>
    public async Task<Result<TransactionHistoryReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<TransactionHistory, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="TransactionHistoryReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<TransactionHistoryReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<TransactionHistory,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="TransactionHistory" />.
    /// </summary>
     public async Task<Result<TransactionHistoryReadModel>> CreateAsync(TransactionHistoryCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<TransactionHistory, TransactionHistoryCreatedEvent, int>(createModel,
         new TransactionHistoryCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="TransactionHistory" />.
    /// </summary>
     public async Task<Result<TransactionHistoryReadModel>> Update(int id,
       TransactionHistoryUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<TransactionHistory, TransactionHistoryUpdatedEvent, int>(id,
         updateModel,
         new TransactionHistoryUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="TransactionHistory" />.
    /// </summary>
      public virtual async Task<Result<TransactionHistoryReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<TransactionHistory, TransactionHistoryDeletedEvent, int>(id,
         new TransactionHistoryDeletedEvent(),
         cancellationToken);

    #endregion
}
