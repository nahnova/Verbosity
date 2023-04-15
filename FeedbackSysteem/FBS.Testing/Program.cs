// Import required namespaces
using System;
using FBS.DataAccess;

// Define namespace for the current class
namespace FBS.Test
{
    // Define the main class
    class Program
    {
        // Define the main method
        static void Main(string[] args)
        {
            // Create an instance of the FeedbackCollectionDBDataAccess class
            FeedbackCollectionDBDataAccess db = new FeedbackCollectionDBDataAccess();

            // Test the ExecuteQuery method
            string sql = "SELECT * FROM feedback";
            var dataSet = db.ExecuteQuery(sql);
            // Loop through the rows of the returned dataset and print them to the console
            foreach (System.Data.DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Feedback"]);
            }

            // Test the ExecuteQueryTable method
            var dataTable = db.ExecuteQueryTable(sql);
            // Loop through the rows of the returned datatable and print them to the console
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                Console.WriteLine("{0} {1} {2}", row["ID"], row["Name"], row["Feedback"]);
            }

            // Test the ExecuteDMLQuery method
            sql = "INSERT INTO feedback (Name, Feedback) VALUES ('John', 'This is a test feedback')";
            int rowsAffected = db.ExecuteDMLQuery(sql);
            // Print the number of affected rows to the console
            Console.WriteLine("{0} rows affected.", rowsAffected);

            // Test the GetSingleData method
            string query = "SELECT * FROM feedback WHERE ID = 1";
            string columnName = "Name";
            string result = db.GetSingleData(query, columnName);
            // Print the result of the query to the console
            Console.WriteLine("Result: {0}", result);
        }
    }
}
