using System.Linq;

namespace BlazorApp2.Models
{
    public interface IHaberRepository
    {
        IQueryable<Haber> Habers { get; }

        void SaveHaber(Haber p);
        void CreateHaber(Haber p);
        void DeleteHaber(Haber p);

    }
}
