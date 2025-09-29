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
/// Repository class representing data for table 'BillOfMaterials'.
/// </summary>
public class BillOfMaterialsRepository
    : EntityRepository<BillOfMaterialsReadModel, BillOfMaterialsCreateModel, BillOfMaterialsUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsRepository"/> class.
    /// </summary>
    public BillOfMaterialsRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<BillOfMaterialsRepository> logger,
        IValidator<BillOfMaterialsCreateModel> createValidator,
        IValidator<BillOfMaterialsUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="BillOfMaterialsReadModel" />.
    /// </summary>
    public async Task<Result<BillOfMaterialsReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<BillOfMaterials, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="BillOfMaterialsReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<BillOfMaterialsReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<BillOfMaterials,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="BillOfMaterials" />.
    /// </summary>
     public async Task<Result<BillOfMaterialsReadModel>> CreateAsync(BillOfMaterialsCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<BillOfMaterials, BillOfMaterialsCreatedEvent, int>(createModel,
         new BillOfMaterialsCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="BillOfMaterials" />.
    /// </summary>
     public async Task<Result<BillOfMaterialsReadModel>> Update(int id,
       BillOfMaterialsUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<BillOfMaterials, BillOfMaterialsUpdatedEvent, int>(id,
         updateModel,
         new BillOfMaterialsUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="BillOfMaterials" />.
    /// </summary>
      public virtual async Task<Result<BillOfMaterialsReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<BillOfMaterials, BillOfMaterialsDeletedEvent, int>(id,
         new BillOfMaterialsDeletedEvent(),
         cancellationToken);

    #endregion
}
