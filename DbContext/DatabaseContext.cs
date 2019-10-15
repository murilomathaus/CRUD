using System;
using DatabaseContextLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContextLibrary
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Client> Clietns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Clients.db");
    }
}
