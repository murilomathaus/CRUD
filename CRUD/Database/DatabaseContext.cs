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
        private static DatabaseContext instance;

        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CRUD/Clients.db")}");

        private DatabaseContext()
        {

        }

        public static DatabaseContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(DatabaseContext));
                }
                if (instance == null)
                {
                    instance = new DatabaseContext();
                }

                return instance;
            }
        }
    }
}
