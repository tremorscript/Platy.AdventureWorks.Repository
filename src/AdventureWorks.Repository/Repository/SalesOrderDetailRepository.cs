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
/// Repository class representing data for table 'SalesOrderDetail'.
/// </summary>
public class SalesOrderDetailRepository
    : EntityRepository<SalesOrderDetailReadModel, SalesOrderDetailCreateModel, SalesOrderDetailUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetailRepository"/> class.
    /// </summary>
    public SalesOrderDetailRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<SalesOrderDetailRepository> logger,
        IValidator<SalesOrderDetailCreateModel> createValidator,
        IValidator<SalesOrderDetailUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="SalesOrderDetailReadModel" />.
    /// </summary>
    public async Task<Result<SalesOrderDetailReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<SalesOrderDetail, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="SalesOrderDetailReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<SalesOrderDetailReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<SalesOrderDetail,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="SalesOrderDetail" />.
    /// </summary>
     public async Task<Result<SalesOrderDetailReadModel>> CreateAsync(SalesOrderDetailCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<SalesOrderDetail, SalesOrderDetailCreatedEvent, int>(createModel,
         new SalesOrderDetailCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="SalesOrderDetail" />.
    /// </summary>
     public async Task<Result<SalesOrderDetailReadModel>> Update(int id,
       SalesOrderDetailUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<SalesOrderDetail, SalesOrderDetailUpdatedEvent, int>(id,
         updateModel,
         new SalesOrderDetailUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="SalesOrderDetail" />.
    /// </summary>
      public virtual async Task<Result<SalesOrderDetailReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<SalesOrderDetail, SalesOrderDetailDeletedEvent, int>(id,
         new SalesOrderDetailDeletedEvent(),
         cancellationToken);

    #endregion
}
