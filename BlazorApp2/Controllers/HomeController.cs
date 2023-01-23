using BlazorApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BlazorApp2.Controllers
{
    public class HomeController : Controller
    {
        private IHaberRepository repository;
        public HomeController(IHaberRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Category(string category)
        {
            List<Haber>a;
            if (category!=null)
            {
                a = repository.Habers.Where(i => i.HaberCategory == category).ToList();
                ViewBag.x = category;
            }
            else
            {
                a = repository.Habers.ToList();
                ViewBag.x = "Tüm Kategoriler";
            }
            
            ViewBag.a = category;
            return View(a);
        }
    }
}
