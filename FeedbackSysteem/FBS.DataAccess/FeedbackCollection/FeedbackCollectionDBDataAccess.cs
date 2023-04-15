using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBS.DataAccess
{
    public class FeedbackCollectionDBDataAccess
    {
        private SqlConnection sqlcon;  // Field to hold the database connection
        public SqlConnection Sqlcon   // Public property to access the database connection
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;  // Field to hold the SQL command
        public SqlCommand Sqlcom   // Public property to access the SQL command
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;  // Field to hold the SQL data adapter
        public SqlDataAdapter Sda   // Public property to access the SQL data adapter
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;  // Field to hold the data set
        public DataSet Ds   // Public property to access the data set
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        // Constructor to establish the database connection
        public FeedbackCollectionDBDataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-FS0T5UA;Initial Catalog=feedbackDB;Integrated Security=True");
            Sqlcon.Open();
            Console.WriteLine("The SQL Connection is working");
        }

        // Method to set the SQL command text
        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        // Method to execute a SQL query and return the data set
        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        // Method to execute a SQL query and return the data table
        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        // Method to execute a SQL query that modifies the data and return the number of rows affected
        public int ExecuteDMLQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        // Method to execute a SQL query that returns a single column value
        public string GetSingleData(string query, string columnName)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            string columnData = null;
            try
            {
                connection = sqlcon;
                SqlCommand cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    columnData = reader[columnName].ToString();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                reader?.Close();
            }
            return columnData;
        }
    }
}
