using System.Linq.Expressions;

namespace Spotify.Framework.Data.Repositories.Abstractions;

public interface IRepositoryBase
{
    Task<TEntity> CreateAsync<TModelRequest, TEntity>(TModelRequest request,
        CancellationToken cancellationToken = default);

    Task<TEntity> UpdateAsync<TModelRequest, TEntity>(TModelRequest request,
        CancellationToken cancellationToken = default);

    Task<TEntity> DeleteAsync<TModelRequest, TEntity>(TModelRequest request,
        CancellationToken cancellationToken = default);

    Task<IEnumerable<TEntity>> GetManyAsync<TModelRequest, TEntity>(TModelRequest request,
        CancellationToken cancellationToken = default);

    Task<TEntity> GetOneAsync<TEntity>(Expression<Func<TEntity, bool>> expression,
        CancellationToken cancellationToken = default);
}