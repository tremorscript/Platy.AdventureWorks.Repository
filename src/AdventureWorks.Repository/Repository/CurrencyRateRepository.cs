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
/// Repository class representing data for table 'CurrencyRate'.
/// </summary>
public class CurrencyRateRepository
    : EntityRepository<CurrencyRateReadModel, CurrencyRateCreateModel, CurrencyRateUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrencyRateRepository"/> class.
    /// </summary>
    public CurrencyRateRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<CurrencyRateRepository> logger,
        IValidator<CurrencyRateCreateModel> createValidator,
        IValidator<CurrencyRateUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="CurrencyRateReadModel" />.
    /// </summary>
    public async Task<Result<CurrencyRateReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<CurrencyRate, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="CurrencyRateReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<CurrencyRateReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<CurrencyRate,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="CurrencyRate" />.
    /// </summary>
     public async Task<Result<CurrencyRateReadModel>> CreateAsync(CurrencyRateCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<CurrencyRate, CurrencyRateCreatedEvent, int>(createModel,
         new CurrencyRateCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="CurrencyRate" />.
    /// </summary>
     public async Task<Result<CurrencyRateReadModel>> Update(int id,
       CurrencyRateUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<CurrencyRate, CurrencyRateUpdatedEvent, int>(id,
         updateModel,
         new CurrencyRateUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="CurrencyRate" />.
    /// </summary>
      public virtual async Task<Result<CurrencyRateReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<CurrencyRate, CurrencyRateDeletedEvent, int>(id,
         new CurrencyRateDeletedEvent(),
         cancellationToken);

    #endregion
}
