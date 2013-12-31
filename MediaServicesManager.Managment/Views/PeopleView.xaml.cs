using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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

namespace MediaServicesManager.Management.Views
{
    /// <summary>
    /// Interaction logic for PeopleView.xaml
    /// </summary>
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class PeopleView : UserControl
    {
        public PeopleView()
        {
            InitializeComponent();
        }

        [Import]
        public PeopleViewModel ViewModel
        {
            set { this.DataContext = value; }
        }
    }
}
