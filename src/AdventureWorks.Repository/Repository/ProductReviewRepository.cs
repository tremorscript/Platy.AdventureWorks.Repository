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
/// Repository class representing data for table 'ProductReview'.
/// </summary>
public class ProductReviewRepository
    : EntityRepository<ProductReviewReadModel, ProductReviewCreateModel, ProductReviewUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReviewRepository"/> class.
    /// </summary>
    public ProductReviewRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductReviewRepository> logger,
        IValidator<ProductReviewCreateModel> createValidator,
        IValidator<ProductReviewUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductReviewReadModel" />.
    /// </summary>
    public async Task<Result<ProductReviewReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductReview, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductReviewReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductReviewReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ProductReview,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductReview" />.
    /// </summary>
     public async Task<Result<ProductReviewReadModel>> CreateAsync(ProductReviewCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ProductReview, ProductReviewCreatedEvent, int>(createModel,
         new ProductReviewCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductReview" />.
    /// </summary>
     public async Task<Result<ProductReviewReadModel>> Update(int id,
       ProductReviewUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ProductReview, ProductReviewUpdatedEvent, int>(id,
         updateModel,
         new ProductReviewUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductReview" />.
    /// </summary>
      public virtual async Task<Result<ProductReviewReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ProductReview, ProductReviewDeletedEvent, int>(id,
         new ProductReviewDeletedEvent(),
         cancellationToken);

    #endregion
}
