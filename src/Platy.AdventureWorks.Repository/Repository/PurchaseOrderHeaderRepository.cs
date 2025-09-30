using Ardalis.Result;
using FluentValidation;
using MediatR;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;

namespace Platy.AdventureWorks.Repository;

/// <summary>
///   Repository class representing data for table 'PurchaseOrderHeader'.
/// </summary>
public class PurchaseOrderHeaderRepository
  : EntityRepository<PurchaseOrderHeader, int, PurchaseOrderHeaderReadModel, PurchaseOrderHeaderCreateModel,
    PurchaseOrderHeaderUpdateModel>, IPurchaseOrderHeaderRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="PurchaseOrderHeaderRepository" /> class.
  /// </summary>
  public PurchaseOrderHeaderRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<PurchaseOrderHeaderRepository> logger,
    IValidator<PurchaseOrderHeaderCreateModel> createValidator,
    IValidator<PurchaseOrderHeaderUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="PurchaseOrderHeaderReadModel" />.
  /// </summary>
  public async Task<Result<PurchaseOrderHeaderReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<PurchaseOrderHeader, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="PurchaseOrderHeaderReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<PurchaseOrderHeaderReadModel>>> List(CancellationToken cancellationToken)
  {
    return await QueryModel<PurchaseOrderHeader, int>(null, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="PurchaseOrderHeader" />.
  /// </summary>
  public async Task<Result<PurchaseOrderHeaderReadModel>> CreateAsync(PurchaseOrderHeaderCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new PurchaseOrderHeaderCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="PurchaseOrderHeader" />.
  /// </summary>
  public async Task<Result<PurchaseOrderHeaderReadModel>> Update(int id,
    PurchaseOrderHeaderUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new PurchaseOrderHeaderUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="PurchaseOrderHeader" />.
  /// </summary>
  public virtual async Task<Result<PurchaseOrderHeaderReadModel>> Delete(int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new PurchaseOrderHeaderDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IPurchaseOrderHeaderRepository
  : IRepository<PurchaseOrderHeader, int, PurchaseOrderHeaderReadModel, PurchaseOrderHeaderCreateModel,
    PurchaseOrderHeaderUpdateModel>
{
}
