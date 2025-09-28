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
/// Repository class representing data for table 'SalesOrderHeader'.
/// </summary>
public class SalesOrderHeaderRepository
    : EntityRepository<SalesOrderHeaderReadModel, SalesOrderHeaderCreateModel, SalesOrderHeaderUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderRepository"/> class.
    /// </summary>
    public SalesOrderHeaderRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<SalesOrderHeaderRepository> logger,
        IValidator<SalesOrderHeaderCreateModel> createValidator,
        IValidator<SalesOrderHeaderUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="SalesOrderHeaderReadModel" />.
    /// </summary>
    public async Task<Result<SalesOrderHeaderReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<SalesOrderHeader, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="SalesOrderHeaderReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<SalesOrderHeaderReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<SalesOrderHeader,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="SalesOrderHeader" />.
    /// </summary>
     public async Task<Result<SalesOrderHeaderReadModel>> CreateAsync(SalesOrderHeaderCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<SalesOrderHeader, SalesOrderHeaderCreatedEvent, int>(createModel,
         new SalesOrderHeaderCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="SalesOrderHeader" />.
    /// </summary>
     public async Task<Result<SalesOrderHeaderReadModel>> Update(int id,
       SalesOrderHeaderUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<SalesOrderHeader, SalesOrderHeaderUpdatedEvent, int>(id,
         updateModel,
         new SalesOrderHeaderUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="SalesOrderHeader" />.
    /// </summary>
      public virtual async Task<Result<SalesOrderHeaderReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<SalesOrderHeader, SalesOrderHeaderDeletedEvent, int>(id,
         new SalesOrderHeaderDeletedEvent(),
         cancellationToken);

    #endregion
}
