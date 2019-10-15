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
        void Create(Client client);
        Client Read(int? Id = null);
        void Update(Client client);
        void Delete(Client client);
    }
}
