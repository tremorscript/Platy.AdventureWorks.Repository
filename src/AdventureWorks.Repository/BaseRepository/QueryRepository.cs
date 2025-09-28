using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using AdventureWorks.Repository.Data;
using AdventureWorks.Repository.Data.Entities;
using Ardalis.Result;
using AutoMapper.QueryableExtensions;

namespace AdventureWorks.Repository.BaseRepository;
  
    public class QueryRepository<TReadModel>(IServiceProvider provider, 
      IMapper mapper, 
      ILogger logger)
      where TReadModel : IEntityReadModel
    {
      private AdventureWorksContext? DataContext { get; } = provider.GetService(typeof(AdventureWorksContext)) as AdventureWorksContext;

        protected IMapper Mapper { get; } = mapper;

        protected virtual async Task<Result<TReadModel>> ReadModel<TEntity,TId>(TId id,
          CancellationToken cancellationToken = default(CancellationToken)) 
          where TEntity : EntityBase<TId>
          where TId : struct, IEquatable<TId> 
        {
            var model = await (DataContext?
              .Set<TEntity>()
              .AsNoTracking()
              .Where(p => p.Id.Equals(id))
              .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
              .FirstOrDefaultAsync(cancellationToken))!.ConfigureAwait(false);

            if (model == null)
            {
              logger.LogDebug("Entity not found {model}", typeof(TReadModel));
              return Result<TReadModel>.NotFound();
            }
            
            logger.LogDebug("Entity found successfully {model}", model);
            return Result<TReadModel>.Success(model);
        }
    
        protected virtual async Task<Result<IReadOnlyList<TReadModel>>> QueryModel<TEntity, TId>(
          Expression<Func<TEntity, bool>>? predicate = null,
          CancellationToken cancellationToken = default(CancellationToken)) 
          where TEntity : EntityBase<TId>
          where TId : struct, IEquatable<TId> 
        {
            var dbSet = DataContext?.Set<TEntity>();

            if (dbSet != null)
            {
              var query = dbSet.AsNoTracking();
              if (predicate != null)
                query = query.Where(predicate);
    
              var results = await query
                .ProjectTo<TReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
    
              return Result<IReadOnlyList<TReadModel>>.Success(results);
            }
             
            return Result<IReadOnlyList<TReadModel>>.NotFound();
        }
    }
