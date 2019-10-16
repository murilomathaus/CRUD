using CRUD.Database;
using CRUD.View;
using CRUD.ViewModel;
using Microsoft.EntityFrameworkCore;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CRUD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
            using (var database = new DatabaseContext())
            {
                Directory.CreateDirectory(DatabaseContext.dbFolder);
                database.Database.EnsureCreated();
            }
        }
    }
}
