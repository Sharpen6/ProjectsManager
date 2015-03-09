using ProjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectsManager.Controller
{
    public class MeetingsModel
    {
        internal void addMeeting(Meeting p)
        {
            int meetingNum = DataQueries.AddNewMeeting(p.location, p.desc, "Professor tester",p.header,DateTime.Now.ToShortDateString());
            foreach (string item in p.students)
            {
                DataQueries.AddMeetingParticipant(meetingNum, item);
            }
            foreach (string item in p.hours)
            {
                DataQueries.AddMeetingHours(meetingNum, item);
            }
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
