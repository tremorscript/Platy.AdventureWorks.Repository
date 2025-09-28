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
/// Repository class representing data for table 'vProductModelCatalogDescription'.
/// </summary>
public class VProductModelCatalogDescriptionRepository
    : EntityRepository<VProductModelCatalogDescriptionReadModel, VProductModelCatalogDescriptionCreateModel, VProductModelCatalogDescriptionUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelCatalogDescriptionRepository"/> class.
    /// </summary>
    public VProductModelCatalogDescriptionRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VProductModelCatalogDescriptionRepository> logger,
        IValidator<VProductModelCatalogDescriptionCreateModel> createValidator,
        IValidator<VProductModelCatalogDescriptionUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VProductModelCatalogDescriptionReadModel" />.
    /// </summary>
    public async Task<Result<VProductModelCatalogDescriptionReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VProductModelCatalogDescription, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VProductModelCatalogDescriptionReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VProductModelCatalogDescriptionReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<VProductModelCatalogDescription,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VProductModelCatalogDescription" />.
    /// </summary>
     public async Task<Result<VProductModelCatalogDescriptionReadModel>> CreateAsync(VProductModelCatalogDescriptionCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<VProductModelCatalogDescription, VProductModelCatalogDescriptionCreatedEvent, int>(createModel,
         new VProductModelCatalogDescriptionCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VProductModelCatalogDescription" />.
    /// </summary>
     public async Task<Result<VProductModelCatalogDescriptionReadModel>> Update(int id,
       VProductModelCatalogDescriptionUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<VProductModelCatalogDescription, VProductModelCatalogDescriptionUpdatedEvent, int>(id,
         updateModel,
         new VProductModelCatalogDescriptionUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VProductModelCatalogDescription" />.
    /// </summary>
      public virtual async Task<Result<VProductModelCatalogDescriptionReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<VProductModelCatalogDescription, VProductModelCatalogDescriptionDeletedEvent, int>(id,
         new VProductModelCatalogDescriptionDeletedEvent(),
         cancellationToken);

    #endregion
}
