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
/// Repository class representing data for table 'ProductSubcategory'.
/// </summary>
public class ProductSubcategoryRepository
    : EntityRepository<ProductSubcategoryReadModel, ProductSubcategoryCreateModel, ProductSubcategoryUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductSubcategoryRepository"/> class.
    /// </summary>
    public ProductSubcategoryRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductSubcategoryRepository> logger,
        IValidator<ProductSubcategoryCreateModel> createValidator,
        IValidator<ProductSubcategoryUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductSubcategoryReadModel" />.
    /// </summary>
    public async Task<Result<ProductSubcategoryReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductSubcategory, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductSubcategoryReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductSubcategoryReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ProductSubcategory,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductSubcategory" />.
    /// </summary>
     public async Task<Result<ProductSubcategoryReadModel>> CreateAsync(ProductSubcategoryCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ProductSubcategory, ProductSubcategoryCreatedEvent, int>(createModel,
         new ProductSubcategoryCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductSubcategory" />.
    /// </summary>
     public async Task<Result<ProductSubcategoryReadModel>> Update(int id,
       ProductSubcategoryUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ProductSubcategory, ProductSubcategoryUpdatedEvent, int>(id,
         updateModel,
         new ProductSubcategoryUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductSubcategory" />.
    /// </summary>
      public virtual async Task<Result<ProductSubcategoryReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ProductSubcategory, ProductSubcategoryDeletedEvent, int>(id,
         new ProductSubcategoryDeletedEvent(),
         cancellationToken);

    #endregion
}
