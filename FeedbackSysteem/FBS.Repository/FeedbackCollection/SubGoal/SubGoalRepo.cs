using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using FBS.DataAccess;

namespace FBS.Repository
{

    public class SubGoalRepo
    {
        private FeedbackCollectionDBDataAccess iDB { get; set; }

        // Constructor that initializes the Feed backCollectionDBDataAccess object
        public SubGoalRepo()
        {
            this.iDB = new FeedbackCollectionDBDataAccess();
        }

        // List of SubGoals
        public List<SubGoal> subGoals = new List<SubGoal>();

        // Add subgoal to a goal
        public void AddSubGoal(int goalId,  string subGoal, string status)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                // Open a new SqlConnection object and set its connection string to the database connection string
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();

                // Define an SQL statement to insert a new subgoal into the database
                string sql = "INSERT INTO SubGoal (goalId,subGoal,status) VALUES(@goalId,@subGoal,@status)";

                // Create a SqlCommand object with the SQL statement and the database connection
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // Add parameters to the SqlCommand object for the new subgoal's details
                    cmd.Parameters.AddWithValue("@goalId", goalId);
                    cmd.Parameters.AddWithValue("@subGoal", subGoal);
                    cmd.Parameters.AddWithValue("@status", status);

                    // Execute the SQL statement to insert the new subgoal
                    cmd.ExecuteNonQuery();
                }
                // Close the database connection
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            finally { connection.Dispose(); }
        }

        /*==========Get the list of Subgoals from the database==========*/
        public void GetSubGoalsFromDatabase(int goalID)
        {
            // Clear the list of subgoals
            subGoals.Clear();

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    // Define an SQL statement to retrieve a list of subgoals for a given goal
                    cmd.CommandText = "SELECT id,goalId,subGoal,status FROM SubGoal WHERE goalID = @goalID";
                    cmd.Parameters.AddWithValue("@goalID", goalID);

                     // Execute the SQL statement and read the results into a SqlDataReader
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            // Extract the subgoal's details from the SqlDataReader and add it to the list of subgoals
                            int iD = Int32.Parse(dataReader[0].ToString());
                            string subgoal = dataReader[2].ToString();
                            string status = dataReader[3].ToString();
                            subGoals.Add(new SubGoal(iD, goalID, subgoal, status));
                        }
                    }
                }
            }
        }

        /*==========Get a single Subgoal from the database==========*/
        /*public SubGoal GetSingleSubGoalByID(int id)
        {
            SubGoal subGoal = new SubGoal(0,"",0);

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id,goalId,subGoal FROM SubGoal WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            subGoal.ID = Int32.Parse(dataReader[0].ToString());
                            subGoal.Subgoal = dataReader[2].ToString();
                            subGoal.SingleGoal.ID = Int32.Parse(dataReader[1].ToString());                         
                        }
                    }
                }
            }
            return subGoal;
        }*/

        //Delete Subgoal
        public void DeleteSubGoal(int id)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "DELETE SubGoal WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { connection.Dispose(); }
        }

        // Update Subgoal
        public void UpdateSubGoalStatus(int goalId,string status)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                foreach (SubGoal subGoal in subGoals.Where(subGoal => subGoal.GoalID == goalId))
                {
                    string sql = "UPDATE SubGoal SET status = @status WHERE goalId = @goalId";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@goalId", goalId);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                } 
                connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { connection.Dispose(); }
        }
    }   
}
