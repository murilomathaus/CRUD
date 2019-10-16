using CRUD.Database;
using CRUD.Model;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUD.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        private int? _searchId;
        public int? SearchId
        {
            get
            {
                return _searchId;
            }

            set
            {
                SetProperty(ref _searchId, value);
                if (value != null)
                {
                    Clients = _dbContext.GetClients().Where(c => c.Index == _searchId).ToList();
                    RaisePropertyChanged(nameof(Clients));
                }
                else
                {
                    Clients = _dbContext.GetClients();
                    RaisePropertyChanged(nameof(Clients));
                }
            }
        }

        private bool _pageType;
        public bool PageType
        {
            get
            {
                return _pageType;
            }

            set
            {
                SetProperty(ref _pageType, value);
            }
        }

        private readonly IDbContextScope _dbContext;
        public ICommand OrderByAgeCommand { get; set; }
        public ICommand OrderByIdCommand { get; set; }
        public ICommand DeleteClientCommand { get; set; }

        public HomeViewModel(IDbContextScope dbContext)
        {
            _dbContext = dbContext;

            OrderByAgeCommand = new DelegateCommand(OrderByAge);
            OrderByIdCommand = new DelegateCommand(OrderById);
            DeleteClientCommand = new DelegateCommand<Client>(DeleteClient);

            Clients = _dbContext.GetClients();
        }

        private void DeleteClient(Client client)
        {
            _dbContext.Delete(client);
        }

        private void OrderByAge()
        {
            Clients = Clients.OrderBy(c => c.Age).ToList();
            RaisePropertyChanged(nameof(Clients));
            PageType = true;
        }

        private void OrderById()
        {
            Clients = Clients.OrderBy(c => c.Index).ToList();
            RaisePropertyChanged(nameof(Clients));
            PageType = false;
        }
    }
}
