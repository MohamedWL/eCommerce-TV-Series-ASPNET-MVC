using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSeries.Data;
using eSeries.Data.Services;
using eSeries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eSeries.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service; //need the appdbcontext since it manages everything that pulls or pushes data

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
            return View(allActors);
        }

        //GET: Actors/Details/1  so by Id
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if(actorDetails == null)
            {
                return View("NotFound");
            }return View(actorDetails);
        }

		//GET: Actors/Create
		public IActionResult Create()
		{
			//send empty view until there's details
			return View();
		}

		[HttpPost]
        public async Task<IActionResult> Create([Bind("FullName","ProfilePictureURL","Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }



		//GET: Actors/Edit/1
		public async Task<IActionResult> Edit(int id)
		{

			var actorDetails = await _service.GetByIdAsync(id);
			if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id,[Bind("Id,FullName", "ProfilePictureURL", "Bio")] Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			await _service.UpdateAsync(id,actor);
			return RedirectToAction(nameof(Index));
		}

        //GET: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {

            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
