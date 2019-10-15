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
        readonly DatabaseContext database = DatabaseContext.Instance;

        public void Create(Client client)
        {
            database.Add(client);
            database.SaveChanges();
        }

        public void Delete(Client client)
        {
            database.Remove(client);
            database.SaveChanges();
        }

        public Client Read(int? Id = null)
        {
            return database.Clients.FirstOrDefault(c=>c.Index == Id);
        }

        public void Update(Client client)
        {
            database.Update(client);
            database.SaveChanges();
        }
    }
}
