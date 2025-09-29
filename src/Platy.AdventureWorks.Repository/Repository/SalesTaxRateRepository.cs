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
/// Repository class representing data for table 'SalesTaxRate'.
/// </summary>
public class SalesTaxRateRepository
    : EntityRepository<SalesTaxRateReadModel, SalesTaxRateCreateModel, SalesTaxRateUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTaxRateRepository"/> class.
    /// </summary>
    public SalesTaxRateRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<SalesTaxRateRepository> logger,
        IValidator<SalesTaxRateCreateModel> createValidator,
        IValidator<SalesTaxRateUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="SalesTaxRateReadModel" />.
    /// </summary>
    public async Task<Result<SalesTaxRateReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<SalesTaxRate, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="SalesTaxRateReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<SalesTaxRateReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<SalesTaxRate,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="SalesTaxRate" />.
    /// </summary>
     public async Task<Result<SalesTaxRateReadModel>> CreateAsync(SalesTaxRateCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<SalesTaxRate, SalesTaxRateCreatedEvent, int>(createModel,
         new SalesTaxRateCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="SalesTaxRate" />.
    /// </summary>
     public async Task<Result<SalesTaxRateReadModel>> Update(int id,
       SalesTaxRateUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<SalesTaxRate, SalesTaxRateUpdatedEvent, int>(id,
         updateModel,
         new SalesTaxRateUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="SalesTaxRate" />.
    /// </summary>
      public virtual async Task<Result<SalesTaxRateReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<SalesTaxRate, SalesTaxRateDeletedEvent, int>(id,
         new SalesTaxRateDeletedEvent(),
         cancellationToken);

    #endregion
}
