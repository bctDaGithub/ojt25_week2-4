using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace todos_backend.Data
{
    public class TodoDBContextFactory : IDesignTimeDbContextFactory<TodosDBContext>
    {
        public TodosDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var connectionString = configurationRoot.GetConnectionString("TodosDatabase");

            var optionBuilder = new DbContextOptionsBuilder<TodosDBContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new TodosDBContext(optionBuilder.Options);
        }
    }
}
