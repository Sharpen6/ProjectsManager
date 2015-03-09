using ProjectsManager.Model;
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

namespace ProjectsManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AdvisorMainMeeting : Window
    {
        public AdvisorMainMeeting()
        {
            InitializeComponent();
        }

        //public Model.Model m_model;

        private Meeting m_lastestMeeting; 
        public Meeting lastestMeeting
        {
            get { return m_lastestMeeting; }
            set { m_lastestMeeting = value; }
        }
        
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MeetingSch ms = new MeetingSch();
            ms.ShowDialog();
            MessageBox.Show("כאן הסתיים הדמו, הפגישה נשמרה וניתן לצפות בה, ומיילים נשלחו למשתתפי האירוע");
        }

        internal Meeting getMeetingData()
        {
            return lastestMeeting;
        }
    }
}
