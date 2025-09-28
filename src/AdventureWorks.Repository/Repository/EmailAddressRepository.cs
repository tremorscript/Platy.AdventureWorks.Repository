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
/// Repository class representing data for table 'EmailAddress'.
/// </summary>
public class EmailAddressRepository
    : EntityRepository<EmailAddressReadModel, EmailAddressCreateModel, EmailAddressUpdateModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAddressRepository"/> class.
    /// </summary>
    public EmailAddressRepository(IServiceProvider serviceProvider,
        IMapper mapper,
        IMediator mediator,
        ILogger<EmailAddressRepository> logger,
        IValidator<EmailAddressCreateModel> createValidator,
        IValidator<EmailAddressUpdateModel> updateValidator)
        : base(serviceProvider, mapper, logger, mediator, createValidator, updateValidator)
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated methods

    /// <summary>
    /// Gets an <see cref="EmailAddressReadModel" />.
    /// </summary>
    public async Task<Result<EmailAddressReadModel>> GetAsync(int id,
      CancellationToken cancellationToken) =>
      await ReadModel<EmailAddress, int>(id,
        cancellationToken);

    /// <summary>
    /// Returns a list of <see cref="EmailAddressReadModel" />.
    /// </summary>
    public async Task<Result<IReadOnlyList<EmailAddressReadModel>>> List(CancellationToken cancellationToken) =>
       await QueryModel<EmailAddress,int>(null, cancellationToken);

    /// <summary>
    /// Creates an <see cref="EmailAddress" />.
    /// </summary>
     public async Task<Result<EmailAddressReadModel>> CreateAsync(EmailAddressCreateModel createModel,
       CancellationToken cancellationToken) =>
       await CreateModel<EmailAddress, EmailAddressCreatedEvent, int>(createModel,
         new EmailAddressCreatedEvent(),
         cancellationToken);

    /// <summary>
    /// Updates a <see cref="EmailAddress" />.
    /// </summary>
     public async Task<Result<EmailAddressReadModel>> Update(int id,
       EmailAddressUpdateModel updateModel,
       CancellationToken cancellationToken) =>
       await UpdateModel<EmailAddress, EmailAddressUpdatedEvent, int>(id,
         updateModel,
         new EmailAddressUpdatedEvent(),
         cancellationToken);

    /// <summary>
    /// Deletes a <see cref="EmailAddress" />.
    /// </summary>
      public virtual async Task<Result<EmailAddressReadModel>> Delete(int id,
       CancellationToken cancellationToken) =>
       await DeleteModel<EmailAddress, EmailAddressDeletedEvent, int>(id,
         new EmailAddressDeletedEvent(),
         cancellationToken);

    #endregion
}
