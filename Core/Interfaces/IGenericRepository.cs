using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specification;

namespace Core.Interfaces
{
    /// <summary>
    /// A Generic Repository Interface defining the methods needed to operate a repo with a provided BaseEntity
    /// </summary>
    /// <typeparam name="T">The entity for the repo, derived from BaseEntity</typeparam>
    public interface IGenericRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Returns a single entity of the id provided
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id);
        /// <summary>
        /// Returns all entities of type provided
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<T>> ListAllAsync();
        /// <summary>
        /// returns a single entity with specifications
        /// </summary>
        /// <param name="spec">The specification class of desired results</param>
        /// <returns></returns>
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        /// <summary>
        /// returns a ReadOnlyList of entitys with specifications
        /// </summary>
        /// <param name="spec">The specification class of desired results</param>
        /// <returns></returns>
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}