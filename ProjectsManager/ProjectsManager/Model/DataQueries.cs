using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Model
{
    class DataQueries
    {
        public static DataTable getAllStudents()
        {
            try
            {
                string query = "Select * from tbl_Student";
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getAllTaskTypes()
        {
            try
            {
                string query = "Select * from tbl_TaskType";
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int getNextMeetingNum()
        {
            string query = "SELECT LAST(ID) FROM tbl_Meeting;";
            object ans = AdoHelper.ExecuteScalar(query);
            return (int)ans;
        }
        public static int AddNewMeeting(string location, string desc,string creator)
        {
            int meetingID = getNextMeetingNum()+1;
            string query = "INSERT INTO tbl_Meeting VALUES (" + meetingID + ",'" + location + "' , '" + desc + "', '"+creator+"');";
            AdoHelper.ExecuteNonQuery(query);
            return meetingID;
        }


        internal static void AddMeetingParticipant(int meetingNum, string item)
        {
            string query = "INSERT INTO tbl_StudentsInMeetings VALUES ('" + item + "', " + meetingNum + ");";
            AdoHelper.ExecuteNonQuery(query);
        }
        internal static void AddMeetingHours(int meetingNum, string item)
        {
            string query = "INSERT INTO tbl_MeetingHours Values ('" + item + "', '" + meetingNum + "',FALSE);";
            AdoHelper.ExecuteNonQuery(query);
        }
        public static int getNextAssignmentNum()
        {
            string query = "SELECT LAST(TaskID) FROM tbl_Task;";
            object ans = AdoHelper.ExecuteScalar(query);
            return (int)ans;
        }
        internal static void AddNewTask(string p1, string p2, string p3, int item, string p4)
        {
            int taskID = getNextAssignmentNum()+1;
            string query = "INSERT INTO tbl_Task Values (" + taskID + ",'" + p1 + "','" + p2
                + "'," + item + ",'" + p3 + "','" + p4 + "',0,0);";
            AdoHelper.ExecuteNonQuery(query);
        }
    }
}
