using System;
using FBS.DataAccess;

namespace FBS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            FeedbackCollectionDBDataAccess db = new FeedbackCollectionDBDataAccess();

            // Test ExecuteQuery
            string sql = "SELECT * FROM feedback";
            var dataSet = db.ExecuteQuery(sql);
            foreach (System.Data.DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Feedback"]);
            }

            // Test ExecuteQueryTable
            var dataTable = db.ExecuteQueryTable(sql);
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Feedback"]);
            }

            // Test ExecuteDMLQuery
            sql = "INSERT INTO feedback (Name, Feedback) VALUES ('John', 'This is a test feedback')";
            int rowsAffected = db.ExecuteDMLQuery(sql);
            Console.WriteLine("{0} rows affected.", rowsAffected);

            // Test GetSingleData
            string query = "SELECT * FROM feedback WHERE ID = 1";
            string columnName = "Name";
            string result = db.GetSingleData(query, columnName);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
