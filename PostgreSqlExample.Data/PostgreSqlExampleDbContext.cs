using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSqlExample.Data
{
    public class PostgreSqlExampleDbContext : DbContext
    {
        public PostgreSqlExampleDbContext(DbContextOptions<PostgreSqlExampleDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Db oluşma esnasında çalışır. ArticleConfiguration bu bölümde çalışır.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreSqlExampleDbContext).Assembly);
        }
    }
}