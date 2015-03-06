using ProjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectsManager.Controller
{
    public class MeetingsModel : Model.Model
    {
        internal void addMeeting(Meeting p)
        {
            throw new NotImplementedException();
        }

        internal List<string> getStudents()
        {
            DataTable dt = DataQueries.getAllStudents();
            List<string> ans = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                ans.Add(row[1].ToString() + " " +row[2].ToString());
            }
            return ans;
        }
    }
}
