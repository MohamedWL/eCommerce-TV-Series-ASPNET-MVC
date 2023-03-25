using eSeries.Models;

namespace eSeries.Data.Services
{
    public interface IActorsService
    {
        //get all actors of the database
        Task<IEnumerable<Actor>> GetAllAsync();
        //get single actor
        Task<Actor> GetByIdAsync(int id);
        //add actor to the db
        Task AddAsync(Actor actor);
        //update data
        Task<Actor> UpdateAsync(int id, Actor newActor);
        //delete method
        Task DeleteAsync(int id);
    }
}
