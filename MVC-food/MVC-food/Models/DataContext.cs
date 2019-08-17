using System.Data.Entity;

namespace MVC_food.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<MVC_food.Models.Food> Foods { get; set; }
    }
}