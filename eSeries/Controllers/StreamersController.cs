using eSeries.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eSeries.Controllers
{
    public class StreamersController : Controller
    {
        private readonly AppDbContext _context; //need the appdbcontext since it manages everything that pulls or pushes data

        public StreamersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allStreamers = await _context.Streamers.ToListAsync(); //the data variable captures the files when you go to the corresponding page, you need a view though
            return View(allStreamers);
        }
    }
}
