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

        public MeetingsModel m_meetingModel;

        public MeetingSch()
        {
            Controller.MeetingController pc = new Controller.MeetingController(this);
            m_meetingModel = pc.m_Model;
            InitializeComponent();
            OnScreenOpened();

        }

        public event Action OnScreenOpened;
        public event Action OnNewMeetingWasCreated;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string date = "Date: "+dt_1.SelectedDate.Value.ToShortDateString() + " " + txt_start.Text + "-" + txt_end.Text;
            foreach (string item in lb_hours.Items)
            {
                if (item == date) return;
            }
            if (m_meetingModel.checkForDoubleHours("Professor tester",date))
            {    
                if (dt_1.SelectedDate != null && txt_end.Text != "" && txt_start.Text != "")
                {
                   lb_hours.Items.Add(date);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lb_studs.SelectedItems.Count==0)
            {
                MessageBox.Show("לא נבחרו סטודנטים");
                return;
            }
            if (lb_hours.Items.Count == 0)
            {
                MessageBox.Show("לא נבחרו שעות לפגישה");
                return;
            }
            m_meetingData = new Meeting();
            m_meetingData.location = txt_Location.Text;
            m_meetingData.desc = txt_desc.Text;
            m_meetingData.hours = lb_hours.Items.Cast<String>().ToList();

            m_meetingData.students = getAllSelectedStudsID();
                
            m_meetingData.header = txt_Header.Text;
            OnNewMeetingWasCreated();
            Close();
        }

        private List<int> getAllSelectedStudsID()
        {
            List<int> ans = new List<int>();
            foreach (ListBoxItem item in lb_studs.SelectedItems)
	        {
                ans.Add(((Student)item.Tag).id);
	        }
            return ans;
        }
    }
}
