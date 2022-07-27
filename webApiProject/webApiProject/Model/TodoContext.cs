using Microsoft.EntityFrameworkCore;

namespace webApiProject.Model
{
   
        public class TodoContext : DbContext
        {
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<TodoItems> TodoItems { get; set; } = null!;
        }
    
}
