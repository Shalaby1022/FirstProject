﻿using APPPRACTICAL.DataContext;
using APPPRACTICAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class ItemsController : Controller
    {

        public ItemsController(AppDbContext db)
        {
            _db = db;


        }
        private readonly AppDbContext _db;
        public IActionResult Index()
        {
            IEnumerable<Item> itemsList = _db.Items.ToList();
            return View(itemsList);
        }

        //Get Actions
        public IActionResult New()
        {

            return View();
        }

    }
}
