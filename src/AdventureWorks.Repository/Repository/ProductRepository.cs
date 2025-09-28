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
/// Repository class representing data for table 'Product'.
/// </summary>
public class ProductRepository
    : EntityRepository<ProductReadModel, ProductCreateModel, ProductUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductRepository"/> class.
    /// </summary>
    public ProductRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductRepository> logger,
        IValidator<ProductCreateModel> createValidator,
        IValidator<ProductUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductReadModel" />.
    /// </summary>
    public async Task<Result<ProductReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<Product, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Product,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Product" />.
    /// </summary>
     public async Task<Result<ProductReadModel>> CreateAsync(ProductCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Product, ProductCreatedEvent, int>(createModel,
         new ProductCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Product" />.
    /// </summary>
     public async Task<Result<ProductReadModel>> Update(int id,
       ProductUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Product, ProductUpdatedEvent, int>(id,
         updateModel,
         new ProductUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Product" />.
    /// </summary>
      public virtual async Task<Result<ProductReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Product, ProductDeletedEvent, int>(id,
         new ProductDeletedEvent(),
         cancellationToken);

    #endregion
}
