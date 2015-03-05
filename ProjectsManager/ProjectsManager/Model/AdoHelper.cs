using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace ProjectsManager.Model
{
    class AdoHelper
    {
        static string connectionString = Properties.Settings.Default.DBConnection;
        static OleDbConnection con = new OleDbConnection(connectionString);

        public static DataTable ExecuteDataTable(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataAdapter tableAdapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                tableAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void ExecuteNonQuery(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static object ExecuteScalar(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
