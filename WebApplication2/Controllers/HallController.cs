using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HallController : Controller
    {
        HallContext _ORM = null;
        public HallController(HallContext ORM)
        {
            _ORM = ORM;
        }

        [HttpGet]
       public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Movie M)
        {
            _ORM.Movie.Add(M);
            _ORM.SaveChanges();

            return View();
        }
        [HttpGet]
        public IActionResult AddCinema()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCinema(Cinema C)
        {
            _ORM.Cinema.Add(C);
            _ORM.SaveChanges();


            return View();
        }
    }
}

