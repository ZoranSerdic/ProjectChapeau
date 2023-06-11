using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public abstract class BaseDAO 
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public BaseDAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Chapeau Project"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            //open the connection
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        /* For Scalar Insert Queries*/
        protected int ExecuteScalarEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            int result = 0;

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;

                // Add each SqlParameter to the SqlCommand
                foreach (SqlParameter parameter in sqlParameters)
                {
                    command.Parameters.Add(new SqlParameter(parameter.ParameterName, parameter.Value));
                }

                result = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }
    }
}