﻿using CRUD.Database;
using CRUD.View;
using CRUD.ViewModel;
using Microsoft.EntityFrameworkCore;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<DbContextScope>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(nameof(HomeViewModel));
            containerRegistry.RegisterForNavigation<NewClientPage, NewClientViewModel>(nameof(NewClientViewModel));
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>(nameof(MainWindowViewModel));
        }
    }
}
