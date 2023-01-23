using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Context
{
    public class AddDbContext : IdentityDbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {
        }
    }
}
