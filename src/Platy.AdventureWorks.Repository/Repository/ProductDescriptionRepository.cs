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
/// Repository class representing data for table 'ProductDescription'.
/// </summary>
public class ProductDescriptionRepository
    : EntityRepository<ProductDescriptionReadModel, ProductDescriptionCreateModel, ProductDescriptionUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDescriptionRepository"/> class.
    /// </summary>
    public ProductDescriptionRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductDescriptionRepository> logger,
        IValidator<ProductDescriptionCreateModel> createValidator,
        IValidator<ProductDescriptionUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductDescriptionReadModel" />.
    /// </summary>
    public async Task<Result<ProductDescriptionReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductDescription, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductDescriptionReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductDescriptionReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ProductDescription,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductDescription" />.
    /// </summary>
     public async Task<Result<ProductDescriptionReadModel>> CreateAsync(ProductDescriptionCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ProductDescription, ProductDescriptionCreatedEvent, int>(createModel,
         new ProductDescriptionCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductDescription" />.
    /// </summary>
     public async Task<Result<ProductDescriptionReadModel>> Update(int id,
       ProductDescriptionUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ProductDescription, ProductDescriptionUpdatedEvent, int>(id,
         updateModel,
         new ProductDescriptionUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductDescription" />.
    /// </summary>
      public virtual async Task<Result<ProductDescriptionReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ProductDescription, ProductDescriptionDeletedEvent, int>(id,
         new ProductDescriptionDeletedEvent(),
         cancellationToken);

    #endregion
}
