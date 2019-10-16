using CRUD.Database;
using CRUD.Model;
using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUD.ViewModel
{
    public class NewClientViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                SetProperty(ref _name, value);
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                SetProperty(ref _lastName, value);
            }
        }
        private string _phone;
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                SetProperty(ref _phone, value);
            }
        }
        private int? _age;
        public int? Age
        {
            get
            {
                return _age;
            }

            set
            {
                SetProperty(ref _age, value);
            }
        }
        public ICommand AddClientCommand { get; set; }
        private bool _confirm;
        public bool Confirm
        {
            get
            {
                return _confirm;
            }

            set
            {
                SetProperty(ref _confirm, value);
            }
        }

        private readonly IDbContextScope _dbContext;
        public NewClientViewModel(IDbContextScope dbContext)
        {
            _dbContext = dbContext;

            AddClientCommand = new DelegateCommand(AddClient, PropertiesNotNull)
                .ObservesProperty(() => Name)
                .ObservesProperty(() => LastName)
                .ObservesProperty(() => Age);
        }

        private void AddClient()
        {
            var id = _dbContext.GetClients().Any() ? _dbContext.GetClients().Max(i => i.Index) : 0; //If there is none, return 0
            _dbContext.Add(new Client() { Name = Name, Age = Age.Value, Index = id + 1, LastName = LastName, Phone = Phone });
            Confirm = true;
            Task.Delay(3000);
            Confirm = false;
        }

        private bool PropertiesNotNull()
        {
            return Name != null && LastName != null && Age != null;
        }

    }
}
