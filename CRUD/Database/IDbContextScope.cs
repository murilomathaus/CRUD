using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Database
{
    public interface IDbContextScope
    {
        void Add(Client client);
        Client Find(int? Id = null);
        void Update(Client client);
        void Delete(Client client);
        List<Client> GetClients();
    }
}
