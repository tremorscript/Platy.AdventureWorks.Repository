using Ardalis.Result;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;

namespace Platy.AdventureWorks.Repository.Interfaces;

public interface ITestRepository<TEntity, TId, TReadModel, TCreateModel, TUpdateModel>
  where TEntity : EntityBase<TId>
  where TId : struct, IEquatable<TId>
  where TReadModel : IEntityReadModel
  where TCreateModel : IEntityCreateModel
  where TUpdateModel : IEntityUpdateModel
{
  /// <summary>
  ///   Gets an <see cref="AddressReadModel" />.
  /// </summary>
  Task<Result<TReadModel>> GetAsync(TId id,
    CancellationToken cancellationToken);

  /// <summary>
  ///   Returns a list of <see cref="AddressReadModel" />.
  /// </summary>
  Task<Result<IReadOnlyList<TReadModel>>> List(CancellationToken cancellationToken);

  /// <summary>
  ///   Creates an <see cref="Address" />.
  /// </summary>
  Task<Result<TReadModel>> CreateAsync(TCreateModel createModel,
    CancellationToken cancellationToken);

  /// <summary>
  ///   Updates a <see cref="Address" />.
  /// </summary>
  Task<Result<TReadModel>> Update(TId id,
    TUpdateModel updateModel,
    CancellationToken cancellationToken);

  /// <summary>
  ///   Deletes a <see cref="Address" />.
  /// </summary>
  Task<Result<TReadModel>> Delete(TId id,
    CancellationToken cancellationToken);
}

public interface IAddressRepository :
  ITestRepository<Address, int, AddressReadModel, AddressCreateModel, AddressUpdateModel>
{
}
