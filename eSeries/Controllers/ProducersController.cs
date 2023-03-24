using eSeries.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eSeries.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context; //need the appdbcontext since it manages everything that pulls or pushes data

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
