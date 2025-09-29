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
/// Repository class representing data for table 'SpecialOffer'.
/// </summary>
public class SpecialOfferRepository
    : EntityRepository<SpecialOfferReadModel, SpecialOfferCreateModel, SpecialOfferUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferRepository"/> class.
    /// </summary>
    public SpecialOfferRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<SpecialOfferRepository> logger,
        IValidator<SpecialOfferCreateModel> createValidator,
        IValidator<SpecialOfferUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="SpecialOfferReadModel" />.
    /// </summary>
    public async Task<Result<SpecialOfferReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<SpecialOffer, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="SpecialOfferReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<SpecialOfferReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<SpecialOffer,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="SpecialOffer" />.
    /// </summary>
     public async Task<Result<SpecialOfferReadModel>> CreateAsync(SpecialOfferCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<SpecialOffer, SpecialOfferCreatedEvent, int>(createModel,
         new SpecialOfferCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="SpecialOffer" />.
    /// </summary>
     public async Task<Result<SpecialOfferReadModel>> Update(int id,
       SpecialOfferUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<SpecialOffer, SpecialOfferUpdatedEvent, int>(id,
         updateModel,
         new SpecialOfferUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="SpecialOffer" />.
    /// </summary>
      public virtual async Task<Result<SpecialOfferReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<SpecialOffer, SpecialOfferDeletedEvent, int>(id,
         new SpecialOfferDeletedEvent(),
         cancellationToken);

    #endregion
}
