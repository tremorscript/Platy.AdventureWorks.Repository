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
/// Repository class representing data for table 'vJobCandidateEducation'.
/// </summary>
public class VJobCandidateEducationRepository
    : EntityRepository<VJobCandidateEducationReadModel, VJobCandidateEducationCreateModel, VJobCandidateEducationUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEducationRepository"/> class.
    /// </summary>
    public VJobCandidateEducationRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<VJobCandidateEducationRepository> logger,
        IValidator<VJobCandidateEducationCreateModel> createValidator,
        IValidator<VJobCandidateEducationUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="VJobCandidateEducationReadModel" />.
    /// </summary>
    public async Task<Result<VJobCandidateEducationReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<VJobCandidateEducation, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="VJobCandidateEducationReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<VJobCandidateEducationReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<VJobCandidateEducation,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="VJobCandidateEducation" />.
    /// </summary>
     public async Task<Result<VJobCandidateEducationReadModel>> CreateAsync(VJobCandidateEducationCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<VJobCandidateEducation, VJobCandidateEducationCreatedEvent, int>(createModel,
         new VJobCandidateEducationCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="VJobCandidateEducation" />.
    /// </summary>
     public async Task<Result<VJobCandidateEducationReadModel>> Update(int id,
       VJobCandidateEducationUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<VJobCandidateEducation, VJobCandidateEducationUpdatedEvent, int>(id,
         updateModel,
         new VJobCandidateEducationUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="VJobCandidateEducation" />.
    /// </summary>
      public virtual async Task<Result<VJobCandidateEducationReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<VJobCandidateEducation, VJobCandidateEducationDeletedEvent, int>(id,
         new VJobCandidateEducationDeletedEvent(),
         cancellationToken);

    #endregion
}
