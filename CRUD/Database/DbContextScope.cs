using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Model;

namespace CRUD.Database
{
    public class DbContextScope : IDbContextScope
    {
        public void Add(Client client)
        {
            using (var database = new DatabaseContext())
            {
                database.Add(client);
                database.SaveChanges();
            }
        }

        public void Delete(Client client)
        {
            using (var database = new DatabaseContext())
            {
                database.Remove(client);
                database.SaveChanges();
            }
        }

        public Client Find(int? Id = null)
        {
            using (var database = new DatabaseContext())
            {
                return database.Clients.FirstOrDefault(c => c.Index == Id);
            }
        }

        public void Update(Client client)
        {
            using (var database = new DatabaseContext())
            {
                database.Update(client);
                database.SaveChanges();
            }
        }
        
        public List<Client> GetClients()
        {
            using (var database = new DatabaseContext())
            {
                return database.Clients.ToList();
            }
        }
    }
}
