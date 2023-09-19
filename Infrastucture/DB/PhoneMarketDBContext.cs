using Domain.Entity;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastucture.DB;

public class PhoneMarketDBContext:DbContext
{
    public PhoneMarketDBContext()
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Favourite> Favorites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=::1; Port=5432; Database=PhoneMarket; User Id=postgres; Password=2004-12-17");
    }
}
