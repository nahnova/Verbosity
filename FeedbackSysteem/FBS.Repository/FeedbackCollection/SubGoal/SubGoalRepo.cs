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
        private FeedbackCollectionDBDataAccess iDB{ get; set; }

        public SubGoalRepo()

        {
            this.iDB = new FeedbackCollectionDBDataAccess();
        }
        public List<SubGoal> subGoals = new List<SubGoal>();


        //Add subgoal to a goal
        public void AddSubGoal(int id, int goalId,string subGoal)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "INSERT INTO SubGoal (id,goalId,subGoal) VALUES(@id,@goalId,@subGoal)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@goalId", goalId);
                    cmd.Parameters.AddWithValue("@subGoal", subGoal);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            finally { connection.Dispose(); }
        }

        /*==========Get the list of Subgoals from the database==========*/
        public void GetSubGoalsFromDatabase()
        {
            subGoals.Clear();

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id,goalId,subGoal FROM SubGoal ORDER BY id";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int iD = Int32.Parse(dataReader[0].ToString());
                            int goalIdInt = Int32.Parse(dataReader[1].ToString());
                            Goal goalId = GetGoalById(goalIdInt); // Replace with the appropriate method to get a Goal instance by Id
                            string subgoal = dataReader[2].ToString();

                            subGoals.Add(new SubGoal(iD, goalId, subgoal));
                        }
                    }
                }
            }
        }


        /*==========Get a single Subgoal from the database==========*/
        public SubGoal GetSingleSubGoalByID(int id)
        {
            SubGoal subGoal = new SubGoal(0,0,"");

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
                            subGoal.subgoal = dataReader[2].ToString();
                            subGoal.Goal.ID = Int32.Parse(dataReader[1].ToString());                         
                        }
                    }
                }
            }
            return subGoal;
        }

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
        public void UpdateSubGoal(int id, int goalId,string subGoal)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "UPDATE SubGoal SET id = @id,goalId = @goalId,subGoal = @subGoal";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@goalId", goalId);
                    cmd.Parameters.AddWithValue("@subGoal",subGoal );
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
    }   
}
