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
/// Repository class representing data for table 'Illustration'.
/// </summary>
public class IllustrationRepository
    : EntityRepository<IllustrationReadModel, IllustrationCreateModel, IllustrationUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IllustrationRepository"/> class.
    /// </summary>
    public IllustrationRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<IllustrationRepository> logger,
        IValidator<IllustrationCreateModel> createValidator,
        IValidator<IllustrationUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="IllustrationReadModel" />.
    /// </summary>
    public async Task<Result<IllustrationReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<Illustration, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="IllustrationReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<IllustrationReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Illustration,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Illustration" />.
    /// </summary>
     public async Task<Result<IllustrationReadModel>> CreateAsync(IllustrationCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Illustration, IllustrationCreatedEvent, int>(createModel,
         new IllustrationCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Illustration" />.
    /// </summary>
     public async Task<Result<IllustrationReadModel>> Update(int id,
       IllustrationUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Illustration, IllustrationUpdatedEvent, int>(id,
         updateModel,
         new IllustrationUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Illustration" />.
    /// </summary>
      public virtual async Task<Result<IllustrationReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Illustration, IllustrationDeletedEvent, int>(id,
         new IllustrationDeletedEvent(),
         cancellationToken);

    #endregion
}
