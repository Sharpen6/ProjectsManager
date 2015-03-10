using ProjectsManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectsManager.Model
{
    public class MeetingsModel
    {
        internal void addMeeting(Meeting p)
        {
            int meetingNum = DataQueries.AddNewMeeting(p.location, p.desc, "Professor tester",p.header,DateTime.Now.ToShortDateString());
            foreach (int item in p.students)
            {
                DataQueries.AddMeetingParticipant(meetingNum, item);
            }
            foreach (string item in p.hours)
            {
                DataQueries.AddMeetingHours(meetingNum, item);
            }
        }

        public bool checkForDoubleHours(string advisor,string hour)
        {
            return DataQueries.CheckHours(advisor, hour);
        }
        internal List<Student> getStudents()
        {
            DataTable dt = DataQueries.getAllStudents();
            List<Student> ans = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                ans.Add(new Student((int)row[0], row[1]+" "+row[2]));
            }
            return ans;
        }
    }
}
