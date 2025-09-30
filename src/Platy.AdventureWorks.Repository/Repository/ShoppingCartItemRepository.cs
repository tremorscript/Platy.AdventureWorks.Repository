using Ardalis.Result;
using FluentValidation;
using MediatR;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;

namespace Platy.AdventureWorks.Repository;

/// <summary>
///   Repository class representing data for table 'ShoppingCartItem'.
/// </summary>
[RegisterScoped]
public class ShoppingCartItemRepository
  : EntityRepository<ShoppingCartItem, int, ShoppingCartItemReadModel, ShoppingCartItemCreateModel,
    ShoppingCartItemUpdateModel>, IShoppingCartItemRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="ShoppingCartItemRepository" /> class.
  /// </summary>
  public ShoppingCartItemRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<ShoppingCartItemRepository> logger,
    IValidator<ShoppingCartItemCreateModel> createValidator,
    IValidator<ShoppingCartItemUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="ShoppingCartItemReadModel" />.
  /// </summary>
  public async Task<Result<ShoppingCartItemReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<ShoppingCartItem, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="ShoppingCartItemReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<ShoppingCartItemReadModel>>> List(CancellationToken cancellationToken)
  {
    return await QueryModel<ShoppingCartItem, int>(null, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="ShoppingCartItem" />.
  /// </summary>
  public async Task<Result<ShoppingCartItemReadModel>> CreateAsync(ShoppingCartItemCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new ShoppingCartItemCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="ShoppingCartItem" />.
  /// </summary>
  public async Task<Result<ShoppingCartItemReadModel>> Update(int id,
    ShoppingCartItemUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new ShoppingCartItemUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="ShoppingCartItem" />.
  /// </summary>
  public virtual async Task<Result<ShoppingCartItemReadModel>> Delete(int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new ShoppingCartItemDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IShoppingCartItemRepository
  : IRepository<ShoppingCartItem, int, ShoppingCartItemReadModel, ShoppingCartItemCreateModel,
    ShoppingCartItemUpdateModel>
{
}
