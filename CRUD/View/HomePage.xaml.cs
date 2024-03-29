﻿using CRUD.Utils;
using CRUD.ViewModel;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUD.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            Binding binding = BindingOperations.GetBinding(SearchBox, TextBox.TextProperty);
            binding.ValidationRules.Clear();
            binding.ValidationRules.Add(new InputValidationRule() { Pattern = "^[0-9]*$", ErrorMessage = "Digite um número" });
        }
    }
}
