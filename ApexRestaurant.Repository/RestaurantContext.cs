using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository
{
    public class RestaurantContext : DbContext
    {
         public RestaurantContext(DbContextOptions<RestaurantContext> options) :base(options)
    {

    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Menu> Menus { get; set; }

    public DbSet<MenuItem> Menu_Items { get; set; }

    public DbSet<RefStaffRole> Ref_Staff_Roles { get; set; }

    public DbSet<Staff> Staffs { get; set; }

    public DbSet<Meal> Meals {get; set;}

    public DbSet<MealDish> MealDishes {get; set;}




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    }

}


