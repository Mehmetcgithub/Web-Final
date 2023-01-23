using BlazorApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlazorApp2.ViewComponents.IndexSliderList
{
    public class IndexSliderList : ViewComponent
    {
        private IHaberRepository repository;
        public IndexSliderList(IHaberRepository repository)
        {
            this.repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            var values = repository.Habers.ToList();
            values.Reverse();
            return View(values);
        }
    }
}
