using System.Text.Json;
using AdventureWorks.Repository;
using AdventureWorks.Repository.BaseEvent;
using AdventureWorks.Repository.Data;
using FluentValidation;
using MediatR;
using Ardalis.Result;
using Ardalis.Result.FluentValidation;

namespace AdventureWorks.Repository.BaseRepository;

    public class EntityRepository<TReadModel, TCreateModel, TUpdateModel> :
      QueryRepository<TReadModel>
        where TReadModel : IEntityReadModel
        where TCreateModel : IEntityCreateModel
        where TUpdateModel : IEntityUpdateModel
    
    {
      private readonly IMediator _mediator;
      private readonly ILogger _logger;
      private AdventureWorksContext DataContext { get; }
        public EntityRepository(IServiceProvider serviceProvider, 
          IMapper mapper,
          ILogger logger,
          IMediator mediator,
          IValidator<TCreateModel> createValidator,
          IValidator<TUpdateModel> updateValidator
          ) 
            : base(serviceProvider, mapper, logger)
        {
            _mediator = mediator;
            _logger = logger;
            DataContext = (AdventureWorksContext)serviceProvider.GetService(typeof(AdventureWorksContext))!;
            CreateValidator = createValidator;
            UpdateValidator = updateValidator;
        }
        
        protected IValidator<TCreateModel> CreateValidator { get; }
    
        protected IValidator<TUpdateModel> UpdateValidator { get; }

        
        /// <summary>
        /// Creates an entity in the database from the model.
        /// </summary>
        /// <param name="createModel">The model of type <see cref="IEntityCreateModel"/></param>
        /// <param name="entityCreatedEvent">The event of type <see cref="EntityEventBase"/></param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <typeparam name="TEntity">The Entity</typeparam>
        /// <typeparam name="TCreateEvent">The Created Event</typeparam>
        /// <typeparam name="TId">The Id</typeparam>
        /// <returns></returns>
        protected virtual async Task<Result<TReadModel>> CreateModel<TEntity, TCreateEvent, TId>(TCreateModel createModel,
          TCreateEvent entityCreatedEvent,
          CancellationToken cancellationToken = default(CancellationToken))
          where TEntity : EntityBase<TId> 
          where TId : struct, IEquatable<TId> 
          where TCreateEvent : EntityEventBase 
        {
            // validate model - Change to Validate
            var validationResult = await CreateValidator.ValidateAsync(createModel, cancellationToken);
            if (!validationResult.IsValid)
            {
              _logger.LogDebug("Model validation failed {validationResult}", validationResult);
              return Result<TReadModel>.Invalid(validationResult.AsErrors());
            }
            _logger.LogDebug("Model validated successfully  {createModel}", createModel);
    
            // create new entity from model
            var entity = Mapper.Map<TEntity>(createModel);
            _logger.LogDebug("Model mapped to entity successfully {entity}", entity);
            
            // add to data set, id should be generated
            await DataContext 
                .Set<TEntity>()
                .AddAsync(entity, cancellationToken);
            _logger.LogDebug("Entity added to data context. {entity}", entity);
    
            // save to database
            await DataContext 
                .SaveChangesAsync(cancellationToken);
            _logger.LogDebug("Entity saved to the database. {entity}", entity);
            
            entityCreatedEvent.JsonData = JsonSerializer.Serialize(entity);
            await _mediator.Publish(entityCreatedEvent, cancellationToken);
            _logger.LogDebug("Entity created events published. {entityEvent}", entity);
    
            // convert to read model
            var readModel = await ReadModel<TEntity, TId>(entity.Id, cancellationToken);
            _logger.LogDebug("Entity mapped back to read model {readModel}", readModel);

            return Result<TReadModel>.Success(readModel);
        }
    
        /// <summary>
        /// Updates an entity in the database from the model.
        /// </summary>
        /// <param name="id">The id of the entity</param>
        /// <param name="updateModel">The model of type <see cref="IEntityUpdateModel"/></param>
        /// <param name="entityUpdatedEvent">The event of type <see cref="EntityEventBase"/></param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <typeparam name="TEntity">The Entity</typeparam>
        /// <typeparam name="TUpdateEvent">The Created Event</typeparam>
        /// <typeparam name="TId">The Id</typeparam>
        /// <returns></returns>
        protected virtual async Task<Result<TReadModel>> UpdateModel<TEntity, TUpdateEvent, TId>(TId id,
          TUpdateModel updateModel,
          TUpdateEvent entityUpdatedEvent,
          CancellationToken cancellationToken = default(CancellationToken))
          where TEntity : EntityBase<TId> 
          where TId : struct, IEquatable<TId> 
          where TUpdateEvent : EntityEventBase 
        {
            // validate model
            var validationResult = await UpdateValidator.ValidateAsync(updateModel, cancellationToken);
            if (!validationResult.IsValid)
            {
              _logger.LogDebug("Model validation failed {validationResult}", validationResult);
              return Result<TReadModel>.Invalid(validationResult.AsErrors());
            }
            _logger.LogDebug("Model validated successfully. {updateModel}", updateModel);
    
            // primary key
            var keyValue = new object[] { id };
    
            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TEntity>()
                .FindAsync(keyValue, cancellationToken);
            _logger.LogDebug("Find the entity in the database. {id}", id);

            if (entity == null)
            {
              _logger.LogDebug("Entity not found");              
              return Result<TReadModel>.NotFound();
            }
    
            // copy updates from model to entity
            Mapper.Map(updateModel, entity);
            _logger.LogDebug("Model mapped to entity successfully. {updateModel}", updateModel);
    
            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);
            _logger.LogDebug("Entity update in the database. {entity}", entity);
            
            // Publish Save event data
            entityUpdatedEvent.JsonData = JsonSerializer.Serialize(entity);
            await _mediator.Publish(entityUpdatedEvent, cancellationToken);
            _logger.LogDebug("Entity update events published: {entityEvent}", entityUpdatedEvent);
    
            // return read model
            var readModel = await ReadModel<TEntity,TId>(id, cancellationToken);
            return Result<TReadModel>.Success(readModel);
        }
    
        protected virtual async Task<Result<TReadModel>> DeleteModel<TEntity,TDeleteEvent, TId>(TId id,
          TDeleteEvent entityDeletedEvent,
          CancellationToken cancellationToken = default(CancellationToken))
          where TEntity : EntityBase<TId> 
          where TId : struct, IEquatable<TId> 
          where TDeleteEvent : EntityEventBase 
        {
            var dbSet = DataContext
                .Set<TEntity>();
    
            var keyValue = new object[] { id };
    
            // find entity to delete by id
            var entity = await dbSet
                .FindAsync(keyValue, cancellationToken);
            _logger.LogDebug("Find the entity in the database {entity}", entity);

            if (entity == null)
            {
              _logger.LogDebug("Entity not found in the database. {entity}", entity);
              return Result<TReadModel>.NotFound();
            }
    
            // return read model
            var readModel = await ReadModel<TEntity, TId>(id, cancellationToken);
            _logger.LogDebug("Read the model from the database {readModel}", readModel);
             
            // delete entry
            dbSet.Remove(entity);
            _logger.LogDebug("Entity removed from the database successfully {entity}", entity);
            
            // save
            await DataContext
                .SaveChangesAsync(cancellationToken);
            _logger.LogDebug("Entity deleted successfully: {entity}", entity);
            
            entityDeletedEvent.JsonData = JsonSerializer.Serialize(entity); 
            await _mediator.Publish(entityDeletedEvent, cancellationToken);
            _logger.LogDebug("Entity delete events published: {entityEvent}", entityDeletedEvent);
            
            return Result<TReadModel>.Success(readModel);
        }
    }
