using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using MySql.Data.EntityFrameworkCore.Query;

namespace SakilaWebServer.Models {
    class SakilaDbContext : DbContext {
        public SakilaDbContext(DbContextOptions<SakilaDbContext> options)
        : base(options) { }

        public DbSet<Actor> Actor { get; set; }
        // DbSet<T> type properties for other domain models
    }

    class SakilaDbContextFactory {
        public static SakilaDbContext Create(string connectionString) {
            var optionsBuilder = new DbContextOptionsBuilder<SakilaDbContext>();
            optionsBuilder.UseMySQL(connectionString);
            var dbContext = new SakilaDbContext(optionsBuilder.Options);
            return dbContext;
        }
    }
}

