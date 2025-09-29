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
/// Repository class representing data for table 'StateProvince'.
/// </summary>
public class StateProvinceRepository
    : EntityRepository<StateProvinceReadModel, StateProvinceCreateModel, StateProvinceUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StateProvinceRepository"/> class.
    /// </summary>
    public StateProvinceRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<StateProvinceRepository> logger,
        IValidator<StateProvinceCreateModel> createValidator,
        IValidator<StateProvinceUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="StateProvinceReadModel" />.
    /// </summary>
    public async Task<Result<StateProvinceReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<StateProvince, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="StateProvinceReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<StateProvinceReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<StateProvince,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="StateProvince" />.
    /// </summary>
     public async Task<Result<StateProvinceReadModel>> CreateAsync(StateProvinceCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<StateProvince, StateProvinceCreatedEvent, int>(createModel,
         new StateProvinceCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="StateProvince" />.
    /// </summary>
     public async Task<Result<StateProvinceReadModel>> Update(int id,
       StateProvinceUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<StateProvince, StateProvinceUpdatedEvent, int>(id,
         updateModel,
         new StateProvinceUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="StateProvince" />.
    /// </summary>
      public virtual async Task<Result<StateProvinceReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<StateProvince, StateProvinceDeletedEvent, int>(id,
         new StateProvinceDeletedEvent(),
         cancellationToken);

    #endregion
}
