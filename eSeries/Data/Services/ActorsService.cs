using eSeries.Models;
using Microsoft.EntityFrameworkCore;

namespace eSeries.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService( AppDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var res = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
             _context.Actors.Remove(res);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var res = await _context.Actors.ToListAsync();
            return res;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var res = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return res;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
