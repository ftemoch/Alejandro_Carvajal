using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;

namespace Clase12.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ViewResult Lista()
        {
            var Movies = _context.Movies.ToList();
            return View(Movies);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.ID == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
    }
}