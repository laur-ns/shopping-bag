﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopping_basket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_basket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
