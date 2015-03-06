using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Controller
{
    public class StudentsDataController
    {
        public MeetingSch m_View;
        public MeetingsModel m_Model;
        public StudentsDataController(MeetingSch m)
        {
            m_View = m;
            m_Model = new MeetingsModel();
            m.OnScreenOpened += new Action(getStudents);
        }

        private void getStudents()
        {
             List<string> students = m_Model.getStudents();
             foreach (var stud in students)
             {
                 m_View.lb_studs.Items.Add(stud);
             }
        }
    }
}
