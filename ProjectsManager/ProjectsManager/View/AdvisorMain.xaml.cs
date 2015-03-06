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
using System.Windows.Shapes;

namespace ProjectsManager
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AdvisorMain : Window
    {
        public AdvisorMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<int> selectedProjects = new List<int>();
            if ((bool)ckb_1.IsChecked)
                selectedProjects.Add(123);
            if ((bool)ckb_2.IsChecked)
                selectedProjects.Add(321);
            if (selectedProjects.Count == 0)
                return;
            AssignmentCr Acr = new AssignmentCr(selectedProjects);
            Acr.Show();
        }
    }
}
