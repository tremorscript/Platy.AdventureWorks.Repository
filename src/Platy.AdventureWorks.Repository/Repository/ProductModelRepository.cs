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
/// Repository class representing data for table 'ProductModel'.
/// </summary>
public class ProductModelRepository
    : EntityRepository<ProductModelReadModel, ProductModelCreateModel, ProductModelUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelRepository"/> class.
    /// </summary>
    public ProductModelRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductModelRepository> logger,
        IValidator<ProductModelCreateModel> createValidator,
        IValidator<ProductModelUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductModelReadModel" />.
    /// </summary>
    public async Task<Result<ProductModelReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductModel, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductModelReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductModelReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ProductModel,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductModel" />.
    /// </summary>
     public async Task<Result<ProductModelReadModel>> CreateAsync(ProductModelCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ProductModel, ProductModelCreatedEvent, int>(createModel,
         new ProductModelCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductModel" />.
    /// </summary>
     public async Task<Result<ProductModelReadModel>> Update(int id,
       ProductModelUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ProductModel, ProductModelUpdatedEvent, int>(id,
         updateModel,
         new ProductModelUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductModel" />.
    /// </summary>
      public virtual async Task<Result<ProductModelReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ProductModel, ProductModelDeletedEvent, int>(id,
         new ProductModelDeletedEvent(),
         cancellationToken);

    #endregion
}
