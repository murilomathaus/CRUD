using CRUD.Database;
using CRUD.View;
using CRUD.ViewModel;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace CRUD
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new MainWindow();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            Container.RegisterInstance<IDbContextScope>(new DbContextScope());
            Container.RegisterTypeForNavigation<HomePage, HomeViewModel>(nameof(HomeViewModel));
            Container.RegisterTypeForNavigation<NewClientPage, NewClientViewModel>(nameof(NewClientViewModel));
            Container.RegisterTypeForNavigation<MainWindow, MainWindowViewModel>(nameof(MainWindowViewModel));
            base.ConfigureContainer();
        }
    }
}
