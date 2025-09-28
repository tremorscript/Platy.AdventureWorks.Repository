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
/// Repository class representing data for table 'PurchaseOrderHeader'.
/// </summary>
public class PurchaseOrderHeaderRepository
    : EntityRepository<PurchaseOrderHeaderReadModel, PurchaseOrderHeaderCreateModel, PurchaseOrderHeaderUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderHeaderRepository"/> class.
    /// </summary>
    public PurchaseOrderHeaderRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<PurchaseOrderHeaderRepository> logger,
        IValidator<PurchaseOrderHeaderCreateModel> createValidator,
        IValidator<PurchaseOrderHeaderUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="PurchaseOrderHeaderReadModel" />.
    /// </summary>
    public async Task<Result<PurchaseOrderHeaderReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<PurchaseOrderHeader, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="PurchaseOrderHeaderReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<PurchaseOrderHeaderReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<PurchaseOrderHeader,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="PurchaseOrderHeader" />.
    /// </summary>
     public async Task<Result<PurchaseOrderHeaderReadModel>> CreateAsync(PurchaseOrderHeaderCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<PurchaseOrderHeader, PurchaseOrderHeaderCreatedEvent, int>(createModel,
         new PurchaseOrderHeaderCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="PurchaseOrderHeader" />.
    /// </summary>
     public async Task<Result<PurchaseOrderHeaderReadModel>> Update(int id,
       PurchaseOrderHeaderUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<PurchaseOrderHeader, PurchaseOrderHeaderUpdatedEvent, int>(id,
         updateModel,
         new PurchaseOrderHeaderUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="PurchaseOrderHeader" />.
    /// </summary>
      public virtual async Task<Result<PurchaseOrderHeaderReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<PurchaseOrderHeader, PurchaseOrderHeaderDeletedEvent, int>(id,
         new PurchaseOrderHeaderDeletedEvent(),
         cancellationToken);

    #endregion
}
