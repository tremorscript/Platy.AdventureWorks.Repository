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
/// Repository class representing data for table 'Department'.
/// </summary>
public class DepartmentRepository
    : EntityRepository<DepartmentReadModel, DepartmentCreateModel, DepartmentUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepartmentRepository"/> class.
    /// </summary>
    public DepartmentRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<DepartmentRepository> logger,
        IValidator<DepartmentCreateModel> createValidator,
        IValidator<DepartmentUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="DepartmentReadModel" />.
    /// </summary>
    public async Task<Result<DepartmentReadModel>> GetAsync(short id,
      CancellationToken cancellationToken) =>
      await ReadModel<Department, short>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="DepartmentReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<DepartmentReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<Department,short>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="Department" />.
    /// </summary>
     public async Task<Result<DepartmentReadModel>> CreateAsync(DepartmentCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<Department, DepartmentCreatedEvent, short>(createModel,
         new DepartmentCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="Department" />.
    /// </summary>
     public async Task<Result<DepartmentReadModel>> Update(short id,
       DepartmentUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<Department, DepartmentUpdatedEvent, short>(id,
         updateModel,
         new DepartmentUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="Department" />.
    /// </summary>
      public virtual async Task<Result<DepartmentReadModel>> Delete(short id,
       CancellationToken cancellationToken) =>
       await DeleteModel<Department, DepartmentDeletedEvent, short>(id,
         new DepartmentDeletedEvent(),
         cancellationToken);

    #endregion
}
