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
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        //internal DataTable dt
        public FeedbackCollectionDBDataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-FS0T5UA;Initial Catalog=feedbackDB;Integrated Security=True");
            Sqlcon.Open();
            Console.WriteLine("The SQL Connection is working");
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public string GetSingleData(string query, string columnName)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            string columnData = null;
            try
            {
                connection = sqlcon;
                SqlCommand cmd = new SqlCommand(query, connection);

                //if (reader.IsClosed)
                //{
                //    reader = new SqlDataReader(connection);
                //}
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
                //connection?.Close();
                reader?.Close();
            }
            return columnData;
        }
    }
}
