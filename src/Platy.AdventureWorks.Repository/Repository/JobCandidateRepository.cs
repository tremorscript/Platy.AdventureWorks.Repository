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
/// Repository class representing data for table 'JobCandidate'.
/// </summary>
public class JobCandidateRepository
    : EntityRepository<JobCandidateReadModel, JobCandidateCreateModel, JobCandidateUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobCandidateRepository"/> class.
    /// </summary>
    public JobCandidateRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<JobCandidateRepository> logger,
        IValidator<JobCandidateCreateModel> createValidator,
        IValidator<JobCandidateUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="JobCandidateReadModel" />.
    /// </summary>
    public async Task<Result<JobCandidateReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<JobCandidate, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="JobCandidateReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<JobCandidateReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<JobCandidate,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="JobCandidate" />.
    /// </summary>
     public async Task<Result<JobCandidateReadModel>> CreateAsync(JobCandidateCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<JobCandidate, JobCandidateCreatedEvent, int>(createModel,
         new JobCandidateCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="JobCandidate" />.
    /// </summary>
     public async Task<Result<JobCandidateReadModel>> Update(int id,
       JobCandidateUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<JobCandidate, JobCandidateUpdatedEvent, int>(id,
         updateModel,
         new JobCandidateUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="JobCandidate" />.
    /// </summary>
      public virtual async Task<Result<JobCandidateReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<JobCandidate, JobCandidateDeletedEvent, int>(id,
         new JobCandidateDeletedEvent(),
         cancellationToken);

    #endregion
}
