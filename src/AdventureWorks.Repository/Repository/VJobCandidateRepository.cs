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
/// Repository class representing data for table 'vJobCandidate'.
/// </summary>
public class VJobCandidateRepository
    : EntityRepository<VJobCandidateReadModel, VJobCandidateCreateModel, VJobCandidateUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateRepository"/> class.
    /// </summary>
    public VJobCandidateRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VJobCandidateRepository> logger,
        IValidator<VJobCandidateCreateModel> createValidator,
        IValidator<VJobCandidateUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VJobCandidateReadModel" />.
    /// </summary>
    public async Task<Result<VJobCandidateReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VJobCandidate, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VJobCandidateReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VJobCandidateReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<VJobCandidate,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VJobCandidate" />.
    /// </summary>
     public async Task<Result<VJobCandidateReadModel>> CreateAsync(VJobCandidateCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<VJobCandidate, VJobCandidateCreatedEvent, int>(createModel,
         new VJobCandidateCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VJobCandidate" />.
    /// </summary>
     public async Task<Result<VJobCandidateReadModel>> Update(int id,
       VJobCandidateUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<VJobCandidate, VJobCandidateUpdatedEvent, int>(id,
         updateModel,
         new VJobCandidateUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VJobCandidate" />.
    /// </summary>
      public virtual async Task<Result<VJobCandidateReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<VJobCandidate, VJobCandidateDeletedEvent, int>(id,
         new VJobCandidateDeletedEvent(),
         cancellationToken);

    #endregion
}
