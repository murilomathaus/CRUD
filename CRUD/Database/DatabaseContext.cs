using CRUD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Database
{
    public sealed class DatabaseContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public static readonly string dbFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CRUD");
        public static readonly string dbFile = "Clients.db";
        private readonly string dbPath = Path.Combine(dbFolder, dbFile);


        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite($"Filename={dbPath}");

    }
}
