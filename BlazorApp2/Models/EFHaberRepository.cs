using BlazorApp2.Context;
using System.Linq;

namespace BlazorApp2.Models
{
    public class EFHaberRepository : IHaberRepository
    {
        private HaberDbContext context;

        public EFHaberRepository(HaberDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Haber> Habers => context.habers;

        public void CreateHaber(Haber p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteHaber(Haber p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveHaber(Haber p)
        {   
            context.Update(p);
            context.SaveChanges();
        }
    }
}
