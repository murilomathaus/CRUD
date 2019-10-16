using CRUD.Database;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        private readonly IDbContextScope _dbContext;

        public HomeViewModel(IDbContextScope dbContext)
        {
            _dbContext = dbContext;
#if DEBUG
            Clients = _dbContext.GetClients();
#endif
        }       
    }
}
