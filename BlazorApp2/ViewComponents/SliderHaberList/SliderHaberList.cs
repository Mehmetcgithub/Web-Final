using BlazorApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BlazorApp2.ViewComponents.SliderHaberList
{
    public class SliderHaberList:ViewComponent
    {

        private IHaberRepository repository;
        public SliderHaberList(IHaberRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            var values=repository.Habers.Take(7).ToList();
            return View(values);
        }
    }
}
