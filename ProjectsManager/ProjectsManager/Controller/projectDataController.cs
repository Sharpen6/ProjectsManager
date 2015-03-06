using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectsManager.Controller
{
    class projectDataController
    {
        public StudentMain m_View;
        public MeetingsModel m_Model;

        public projectDataController(StudentMain w)
        {
            m_View = w;
            m_Model = new MeetingsModel();
            m_View.OnNewMeetingWasCreated += new Action(getNewMeetingData);
        }

        private void getNewMeetingData()
        {
            m_Model.addMeeting(m_View.getMeetingData());
        }




    }
}
