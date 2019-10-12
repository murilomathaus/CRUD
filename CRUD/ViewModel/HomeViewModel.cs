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

        public HomeViewModel()
        {
#if DEBUG
            Clients.Add(new Client() { Name = "José", Age = 32, Index = 1, LastName = "Silva" });
#endif
        }
    }
}
