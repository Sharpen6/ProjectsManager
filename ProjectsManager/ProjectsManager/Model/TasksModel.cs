using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Model
{
    class TasksModel
    {
        internal List<string> getTaskTypes()
        {
            DataTable dt = DataQueries.getAllTaskTypes();
            List<string> ans = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                ans.Add(row[1].ToString());
            }
            return ans;
        }

        internal void addAssignment(Assignment a)
        {
            foreach (var item in a.projects)
	        {
		         DataQueries.AddNewTask(a.desc, a.creationDate,a.dueDate, item ,"Professor tester");
	        }
            
        }
    }
}
