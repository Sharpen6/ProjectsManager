using ProjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Controller
{
    class TasksController
    {
        public AssignmentCr m_View;
        public TasksModel m_Model;
        public TasksController(AssignmentCr m)
        {
            m_View = m;
            m_Model = new TasksModel();
            m_View.OnScreenOpened += new Action(getTaskTypes);
            m_View.OnNewAssignmentWasCreated += new Action(saveAssignment);
        }

        private void getTaskTypes()
        {
             List<string> types = m_Model.getTaskTypes();
             foreach (var item in types)
             {
                 m_View.cb_types.Items.Add(item);
             }
        }

        private void saveAssignment()
        {
            m_Model.addAssignment(m_View.m_assignmentData);
        }
    }
}
