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
    public partial class AssignmentCr : Window
    {

        public Assignment m_assignmentData;

        public AssignmentCr(List<int> selectedProjects)
        {
            m_assignmentData = new Assignment();
            /*foreach (var item in selectedProjects)
            {
                m_assignmentData.projects.Add(item);
            }*/
            m_assignmentData.projects = selectedProjects;
            Controller.TasksController pc = new Controller.TasksController(this);
            InitializeComponent();
            OnScreenOpened();

        }

        public event Action OnScreenOpened;
        public event Action OnNewAssignmentWasCreated;


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txt_desc.Text=="")
            {
                MessageBox.Show("עליך לכתוב תיאור");
                return;
            }
            if (dt_1.SelectedDate==null)
            {
                MessageBox.Show("לא נבחר תאריך הגשה");
                return;
            }
            m_assignmentData.dueDate=dt_1.SelectedDate.Value.ToShortDateString();
            m_assignmentData.desc = txt_desc.Text;
            m_assignmentData.creationDate = DateTime.Now.ToShortDateString();
            OnNewAssignmentWasCreated();
            Close();
        }
    }
}
