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
/// Repository class representing data for table 'ShoppingCartItem'.
/// </summary>
public class ShoppingCartItemRepository
    : EntityRepository<ShoppingCartItemReadModel, ShoppingCartItemCreateModel, ShoppingCartItemUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShoppingCartItemRepository"/> class.
    /// </summary>
    public ShoppingCartItemRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<ShoppingCartItemRepository> logger,
        IValidator<ShoppingCartItemCreateModel> createValidator,
        IValidator<ShoppingCartItemUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="ShoppingCartItemReadModel" />.
    /// </summary>
    public async Task<Result<ShoppingCartItemReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<ShoppingCartItem, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="ShoppingCartItemReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<ShoppingCartItemReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<ShoppingCartItem,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="ShoppingCartItem" />.
    /// </summary>
     public async Task<Result<ShoppingCartItemReadModel>> CreateAsync(ShoppingCartItemCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<ShoppingCartItem, ShoppingCartItemCreatedEvent, int>(createModel,
         new ShoppingCartItemCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="ShoppingCartItem" />.
    /// </summary>
     public async Task<Result<ShoppingCartItemReadModel>> Update(int id,
       ShoppingCartItemUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<ShoppingCartItem, ShoppingCartItemUpdatedEvent, int>(id,
         updateModel,
         new ShoppingCartItemUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="ShoppingCartItem" />.
    /// </summary>
      public virtual async Task<Result<ShoppingCartItemReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<ShoppingCartItem, ShoppingCartItemDeletedEvent, int>(id,
         new ShoppingCartItemDeletedEvent(),
         cancellationToken);

    #endregion
}
