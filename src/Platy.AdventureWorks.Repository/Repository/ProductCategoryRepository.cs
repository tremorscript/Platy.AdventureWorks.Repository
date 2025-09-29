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
/// Repository class representing data for table 'ProductCategory'.
/// </summary>
public class ProductCategoryRepository
    : EntityRepository<ProductCategoryReadModel, ProductCategoryCreateModel, ProductCategoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCategoryRepository"/> class.
    /// </summary>
    public ProductCategoryRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductCategoryRepository> logger,
        IValidator<ProductCategoryCreateModel> createValidator,
        IValidator<ProductCategoryUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductCategoryReadModel" />.
    /// </summary>
    public async Task<Result<ProductCategoryReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductCategory, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductCategoryReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductCategoryReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ProductCategory,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductCategory" />.
    /// </summary>
     public async Task<Result<ProductCategoryReadModel>> CreateAsync(ProductCategoryCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ProductCategory, ProductCategoryCreatedEvent, int>(createModel,
         new ProductCategoryCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductCategory" />.
    /// </summary>
     public async Task<Result<ProductCategoryReadModel>> Update(int id,
       ProductCategoryUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ProductCategory, ProductCategoryUpdatedEvent, int>(id,
         updateModel,
         new ProductCategoryUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductCategory" />.
    /// </summary>
      public virtual async Task<Result<ProductCategoryReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ProductCategory, ProductCategoryDeletedEvent, int>(id,
         new ProductCategoryDeletedEvent(),
         cancellationToken);

    #endregion
}
