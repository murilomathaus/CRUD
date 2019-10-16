using CRUD.Utils;
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

namespace CRUD.ViewModel
{
    /// <summary>
    /// Interaction logic for NewClientPage.xaml
    /// </summary>
    public partial class NewClientPage : Page
    {
        public NewClientPage()
        {
            InitializeComponent();
            Binding binding = BindingOperations.GetBinding(AgeText, TextBox.TextProperty);
            binding.ValidationRules.Clear();
            binding.ValidationRules.Add(new InputValidationRule() {Pattern = "^[0-9]*$", ErrorMessage = "Digite um número"});
        }
    }
}
