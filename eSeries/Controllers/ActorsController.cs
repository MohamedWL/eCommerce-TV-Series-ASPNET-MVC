using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSeries.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eSeries.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context; //need the appdbcontext since it manages everything that pulls or pushes data

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _context.Actors.ToListAsync();
            return View(allActors);
        }
    }
}
