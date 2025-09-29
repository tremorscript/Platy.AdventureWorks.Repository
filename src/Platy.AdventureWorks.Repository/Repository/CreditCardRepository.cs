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
/// Repository class representing data for table 'CreditCard'.
/// </summary>
public class CreditCardRepository
    : EntityRepository<CreditCardReadModel, CreditCardCreateModel, CreditCardUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardRepository"/> class.
    /// </summary>
    public CreditCardRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<CreditCardRepository> logger,
        IValidator<CreditCardCreateModel> createValidator,
        IValidator<CreditCardUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="CreditCardReadModel" />.
    /// </summary>
    public async Task<Result<CreditCardReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<CreditCard, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="CreditCardReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<CreditCardReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<CreditCard,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="CreditCard" />.
    /// </summary>
     public async Task<Result<CreditCardReadModel>> CreateAsync(CreditCardCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<CreditCard, CreditCardCreatedEvent, int>(createModel,
         new CreditCardCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="CreditCard" />.
    /// </summary>
     public async Task<Result<CreditCardReadModel>> Update(int id,
       CreditCardUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<CreditCard, CreditCardUpdatedEvent, int>(id,
         updateModel,
         new CreditCardUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="CreditCard" />.
    /// </summary>
      public virtual async Task<Result<CreditCardReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<CreditCard, CreditCardDeletedEvent, int>(id,
         new CreditCardDeletedEvent(),
         cancellationToken);

    #endregion
}
