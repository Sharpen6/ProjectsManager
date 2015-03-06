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
using System.Windows.Shapes;

namespace ProjectsManager
{
    /// <summary>
    /// Interaction logic for MeetingSch.xaml
    /// </summary>
    public partial class MeetingSch : Window
    {

        public Meeting m_meetingData;

        public MeetingSch()
        {
            Controller.StudentsDataController pc = new Controller.StudentsDataController(this);
            InitializeComponent();
            OnScreenOpened();

        }

        public event Action OnScreenOpened;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dt_1.SelectedDate != null && txt_end.Text != "" && txt_start.Text != "")
            {
               lb_hours.Items.Add("Date:" + dt_1 + " " + txt_start.Text + "-" + txt_end.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lb_studs.SelectedItems.Count==0)
            {
                MessageBox.Show("לא נבחרו סטודנטים");
                return;
            }
            m_meetingData.location = txt_Location.Text;
            m_meetingData.desc = txt_desc.Text;
            m_meetingData.hours = lb_hours.Items.Cast<String>().ToList();
            m_meetingData.students = lb_studs.SelectedItems.Cast<String>().ToList();
            DialogResult = true;
        }
    }
}
