using Microsoft.EntityFrameworkCore;
using todos_backend.Models;

namespace todos_backend.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                    new Todo()
                    {
                        Id = 1,
                        Name = "Hoc Java",
                        isComplete = false
                    },
                    new Todo()
                    {
                        Id = 2,
                        Name = "Hoc C#",
                        isComplete = false
                    }
                );
        }
    }
}
