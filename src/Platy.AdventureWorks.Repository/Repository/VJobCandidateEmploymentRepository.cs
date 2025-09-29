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
/// Repository class representing data for table 'vJobCandidateEmployment'.
/// </summary>
public class VJobCandidateEmploymentRepository
    : EntityRepository<VJobCandidateEmploymentReadModel, VJobCandidateEmploymentCreateModel, VJobCandidateEmploymentUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEmploymentRepository"/> class.
    /// </summary>
    public VJobCandidateEmploymentRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VJobCandidateEmploymentRepository> logger,
        IValidator<VJobCandidateEmploymentCreateModel> createValidator,
        IValidator<VJobCandidateEmploymentUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VJobCandidateEmploymentReadModel" />.
    /// </summary>
    public async Task<Result<VJobCandidateEmploymentReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VJobCandidateEmployment, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VJobCandidateEmploymentReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VJobCandidateEmploymentReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<VJobCandidateEmployment,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VJobCandidateEmployment" />.
    /// </summary>
     public async Task<Result<VJobCandidateEmploymentReadModel>> CreateAsync(VJobCandidateEmploymentCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<VJobCandidateEmployment, VJobCandidateEmploymentCreatedEvent, int>(createModel,
         new VJobCandidateEmploymentCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VJobCandidateEmployment" />.
    /// </summary>
     public async Task<Result<VJobCandidateEmploymentReadModel>> Update(int id,
       VJobCandidateEmploymentUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<VJobCandidateEmployment, VJobCandidateEmploymentUpdatedEvent, int>(id,
         updateModel,
         new VJobCandidateEmploymentUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VJobCandidateEmployment" />.
    /// </summary>
      public virtual async Task<Result<VJobCandidateEmploymentReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<VJobCandidateEmployment, VJobCandidateEmploymentDeletedEvent, int>(id,
         new VJobCandidateEmploymentDeletedEvent(),
         cancellationToken);

    #endregion
}
