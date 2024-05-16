using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Cargo.Data.Models
{
    public class Context:DbContext
    {
        public DbSet<CargoEntity> Cargo { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
