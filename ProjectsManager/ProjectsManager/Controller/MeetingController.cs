using ProjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProjectsManager.Controller
{
    public class MeetingController
    {
        public MeetingSch m_View;
        public MeetingsModel m_Model;
        public MeetingController(MeetingSch m)
        {
            m_View = m;
            m_Model = new MeetingsModel();
            m_View.OnScreenOpened += new Action(getStudents);
            m_View.OnNewMeetingWasCreated += new Action(getNewMeetingData);
        }

        private void getStudents()
        {
             List<Student> students = m_Model.getStudents();
             foreach (Student stud in students)
             {
                 ListBoxItem lbi = new ListBoxItem();
                 lbi.Tag = stud;
                 lbi.Content = stud.name;
                 m_View.lb_studs.Items.Add(lbi);

             }
        }


        private void getNewMeetingData()
        {

                 m_Model.addMeeting(m_View.m_meetingData);           
        }
    }
}
