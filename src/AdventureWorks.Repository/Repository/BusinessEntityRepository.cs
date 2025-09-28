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
/// Repository class representing data for table 'BusinessEntity'.
/// </summary>
public class BusinessEntityRepository
    : EntityRepository<BusinessEntityReadModel, BusinessEntityCreateModel, BusinessEntityUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityRepository"/> class.
    /// </summary>
    public BusinessEntityRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<BusinessEntityRepository> logger,
        IValidator<BusinessEntityCreateModel> createValidator,
        IValidator<BusinessEntityUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="BusinessEntityReadModel" />.
    /// </summary>
    public async Task<Result<BusinessEntityReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<BusinessEntity, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="BusinessEntityReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<BusinessEntityReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<BusinessEntity,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="BusinessEntity" />.
    /// </summary>
     public async Task<Result<BusinessEntityReadModel>> CreateAsync(BusinessEntityCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<BusinessEntity, BusinessEntityCreatedEvent, int>(createModel,
         new BusinessEntityCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="BusinessEntity" />.
    /// </summary>
     public async Task<Result<BusinessEntityReadModel>> Update(int id,
       BusinessEntityUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<BusinessEntity, BusinessEntityUpdatedEvent, int>(id,
         updateModel,
         new BusinessEntityUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="BusinessEntity" />.
    /// </summary>
      public virtual async Task<Result<BusinessEntityReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<BusinessEntity, BusinessEntityDeletedEvent, int>(id,
         new BusinessEntityDeletedEvent(),
         cancellationToken);

    #endregion
}
