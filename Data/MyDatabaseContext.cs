using DotNetAzure.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAzure.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> Todo { get; set; }
    }
}