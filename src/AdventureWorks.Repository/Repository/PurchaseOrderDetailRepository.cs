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
/// Repository class representing data for table 'PurchaseOrderDetail'.
/// </summary>
public class PurchaseOrderDetailRepository
    : EntityRepository<PurchaseOrderDetailReadModel, PurchaseOrderDetailCreateModel, PurchaseOrderDetailUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderDetailRepository"/> class.
    /// </summary>
    public PurchaseOrderDetailRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<PurchaseOrderDetailRepository> logger,
        IValidator<PurchaseOrderDetailCreateModel> createValidator,
        IValidator<PurchaseOrderDetailUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="PurchaseOrderDetailReadModel" />.
    /// </summary>
    public async Task<Result<PurchaseOrderDetailReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<PurchaseOrderDetail, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="PurchaseOrderDetailReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<PurchaseOrderDetailReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<PurchaseOrderDetail,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="PurchaseOrderDetail" />.
    /// </summary>
     public async Task<Result<PurchaseOrderDetailReadModel>> CreateAsync(PurchaseOrderDetailCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<PurchaseOrderDetail, PurchaseOrderDetailCreatedEvent, int>(createModel,
         new PurchaseOrderDetailCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="PurchaseOrderDetail" />.
    /// </summary>
     public async Task<Result<PurchaseOrderDetailReadModel>> Update(int id,
       PurchaseOrderDetailUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<PurchaseOrderDetail, PurchaseOrderDetailUpdatedEvent, int>(id,
         updateModel,
         new PurchaseOrderDetailUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="PurchaseOrderDetail" />.
    /// </summary>
      public virtual async Task<Result<PurchaseOrderDetailReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<PurchaseOrderDetail, PurchaseOrderDetailDeletedEvent, int>(id,
         new PurchaseOrderDetailDeletedEvent(),
         cancellationToken);

    #endregion
}
