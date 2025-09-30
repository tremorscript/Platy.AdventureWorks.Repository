using Ardalis.Result;
using FluentValidation;
using MediatR;
using Platy.AdventureWorks.Repository.BaseRepository;
using Platy.AdventureWorks.Repository.Data.Entities;
using Platy.AdventureWorks.Repository.Domain.Models;
using Platy.AdventureWorks.Repository.Events;

namespace Platy.AdventureWorks.Repository;

/// <summary>
///   Repository class representing data for table 'vJobCandidateEducation'.
/// </summary>
public class VJobCandidateEducationRepository
  : EntityRepository<VJobCandidateEducation, int, VJobCandidateEducationReadModel, VJobCandidateEducationCreateModel,
    VJobCandidateEducationUpdateModel>, IVJobCandidateEducationRepository
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="VJobCandidateEducationRepository" /> class.
  /// </summary>
  public VJobCandidateEducationRepository(IServiceProvider serviceProvider,
    IMapper mapper,
    IMediator mediator,
    ILogger<VJobCandidateEducationRepository> logger,
    IValidator<VJobCandidateEducationCreateModel> createValidator,
    IValidator<VJobCandidateEducationUpdateModel> updateValidator)
    : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
  {
  }

  #region Generated methods

  /// <summary>
  ///   Gets an <see cref="VJobCandidateEducationReadModel" />.
  /// </summary>
  public async Task<Result<VJobCandidateEducationReadModel>> GetAsync(int id,
    CancellationToken cancellationToken)
  {
    return await ReadModel<VJobCandidateEducation, int>(id,
      cancellationToken);
  }

  /// <summary>
  ///   Returns a list of <see cref="VJobCandidateEducationReadModel" />.
  /// </summary>
  public async Task<Result<IReadOnlyList<VJobCandidateEducationReadModel>>> List(CancellationToken cancellationToken)
  {
    return await QueryModel<VJobCandidateEducation, int>(null, cancellationToken);
  }

  /// <summary>
  ///   Creates an <see cref="VJobCandidateEducation" />.
  /// </summary>
  public async Task<Result<VJobCandidateEducationReadModel>> CreateAsync(VJobCandidateEducationCreateModel createModel,
    CancellationToken cancellationToken)
  {
    return await CreateModel(createModel,
      new VJobCandidateEducationCreatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Updates a <see cref="VJobCandidateEducation" />.
  /// </summary>
  public async Task<Result<VJobCandidateEducationReadModel>> Update(int id,
    VJobCandidateEducationUpdateModel updateModel,
    CancellationToken cancellationToken)
  {
    return await UpdateModel(id,
      updateModel,
      new VJobCandidateEducationUpdatedEvent(),
      cancellationToken);
  }

  /// <summary>
  ///   Deletes a <see cref="VJobCandidateEducation" />.
  /// </summary>
  public virtual async Task<Result<VJobCandidateEducationReadModel>> Delete(int id,
    CancellationToken cancellationToken)
  {
    return await DeleteModel(id,
      new VJobCandidateEducationDeletedEvent(),
      cancellationToken);
  }

  #endregion
}

public interface IVJobCandidateEducationRepository
  : IRepository<VJobCandidateEducation, int, VJobCandidateEducationReadModel, VJobCandidateEducationCreateModel,
    VJobCandidateEducationUpdateModel>
{
}
