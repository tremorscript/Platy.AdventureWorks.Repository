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
/// Repository class representing data for table 'ProductPhoto'.
/// </summary>
public class ProductPhotoRepository
    : EntityRepository<ProductPhotoReadModel, ProductPhotoCreateModel, ProductPhotoUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductPhotoRepository"/> class.
    /// </summary>
    public ProductPhotoRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ProductPhotoRepository> logger,
        IValidator<ProductPhotoCreateModel> createValidator,
        IValidator<ProductPhotoUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ProductPhotoReadModel" />.
    /// </summary>
    public async Task<Result<ProductPhotoReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ProductPhoto, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ProductPhotoReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ProductPhotoReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ProductPhoto,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ProductPhoto" />.
    /// </summary>
     public async Task<Result<ProductPhotoReadModel>> CreateAsync(ProductPhotoCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ProductPhoto, ProductPhotoCreatedEvent, int>(createModel,
         new ProductPhotoCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ProductPhoto" />.
    /// </summary>
     public async Task<Result<ProductPhotoReadModel>> Update(int id,
       ProductPhotoUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ProductPhoto, ProductPhotoUpdatedEvent, int>(id,
         updateModel,
         new ProductPhotoUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ProductPhoto" />.
    /// </summary>
      public virtual async Task<Result<ProductPhotoReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ProductPhoto, ProductPhotoDeletedEvent, int>(id,
         new ProductPhotoDeletedEvent(),
         cancellationToken);

    #endregion
}
