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
        public static DataTable GetAllDepartments()
        {
            try
            {
                string query = "Select * from Departments";
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void AddNewDept(int dptCode, string dptName, string dptLocation)
        {
            string query = "Insert into Departments values(" + dptCode + " , '" + dptName + "' , '" +
           dptLocation + "')";
            AdoHelper.ExecuteNonQuery(query);
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
    }
}
