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
        public static int getNextMeetingNum()
        {
            string query = "SELECT LAST(ID) FROM tbl_Meeting;";
            object ans = AdoHelper.ExecuteScalar(query);
            return (int)ans;
        }
        public static int AddNewMeeting(string location, string desc)
        {
            int meetingID = getNextMeetingNum()+1;
            string query = "INSERT INTO tbl_Meeting VALUES (" + meetingID + ",'" + location + "' , '" + desc + "');";
            AdoHelper.ExecuteNonQuery(query);
            return meetingID;
        }
        public static void UpdateDept(int dptCode, string dptName, string dptLocation)
        {
            string query = "Update Departments set DepName='" + dptName + "', Location='" + dptLocation + "' where DepCode=" + dptCode;
            AdoHelper.ExecuteNonQuery(query);
        }
        public static void DeleteDept(int dptCode)
        {
            string query = "Delete from Departments where DepCode=" + dptCode;
            AdoHelper.ExecuteNonQuery(query);
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
    }
}
