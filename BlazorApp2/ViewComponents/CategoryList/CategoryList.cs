using Microsoft.AspNetCore.Mvc;
using BlazorApp2.Models;
using System.Linq;

namespace BlazorApp2.ViewComponents.CategoryList
{
    public class CategoryList:ViewComponent
    {
        private IHaberRepository repository;
        public CategoryList(IHaberRepository repository)
        {
            this.repository = repository;
        }
        
        public IViewComponentResult Invoke()
        {            
            var values = repository.Habers.Select(x=>x.HaberCategory).Distinct().OrderBy(x => x);
            return View(values);
        }

    }
}
