﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAPIs.Data;
using MusicAPIs.Models;

namespace MusicAPIs.Controllers
{
    public class SongsController : Controller
    {
        private ApiDbContext _dbContext;
        public SongsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get Songs
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return _dbContext.Songs;
        }
        // GET: SongsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SongsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SongsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SongsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SongsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SongsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SongsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SongsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
