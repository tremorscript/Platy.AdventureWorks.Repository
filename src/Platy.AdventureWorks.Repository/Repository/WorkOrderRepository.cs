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
/// Repository class representing data for table 'WorkOrder'.
/// </summary>
public class WorkOrderRepository
    : EntityRepository<WorkOrderReadModel, WorkOrderCreateModel, WorkOrderUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderRepository"/> class.
    /// </summary>
    public WorkOrderRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<WorkOrderRepository> logger,
        IValidator<WorkOrderCreateModel> createValidator,
        IValidator<WorkOrderUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="WorkOrderReadModel" />.
    /// </summary>
    public async Task<Result<WorkOrderReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<WorkOrder, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="WorkOrderReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<WorkOrderReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<WorkOrder,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="WorkOrder" />.
    /// </summary>
     public async Task<Result<WorkOrderReadModel>> CreateAsync(WorkOrderCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<WorkOrder, WorkOrderCreatedEvent, int>(createModel,
         new WorkOrderCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="WorkOrder" />.
    /// </summary>
     public async Task<Result<WorkOrderReadModel>> Update(int id,
       WorkOrderUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<WorkOrder, WorkOrderUpdatedEvent, int>(id,
         updateModel,
         new WorkOrderUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="WorkOrder" />.
    /// </summary>
      public virtual async Task<Result<WorkOrderReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<WorkOrder, WorkOrderDeletedEvent, int>(id,
         new WorkOrderDeletedEvent(),
         cancellationToken);

    #endregion
}
