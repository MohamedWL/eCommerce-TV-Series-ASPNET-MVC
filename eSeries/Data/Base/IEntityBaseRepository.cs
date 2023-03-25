using System.Collections.Generic;

namespace eSeries.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        //get all actors of the database
        Task<IEnumerable<T>> GetAllAsync();
        //get single actor
        Task<T> GetByIdAsync(int id);
        //add actor to the db
        Task AddAsync(T entity);
        //update data
        Task UpdateAsync(int id, T entity);
        //delete method
        Task DeleteAsync(int id);
    }
}
