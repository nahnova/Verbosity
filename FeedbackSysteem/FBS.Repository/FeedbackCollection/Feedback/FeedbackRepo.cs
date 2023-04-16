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

    public class FeedbackRepo

    {
        private FeedbackCollectionDBDataAccess iDB{ get; set; }

        public FeedbackRepo()

        {
            this.iDB = new FeedbackCollectionDBDataAccess();
        }
        public List<Feedback> feedbackList = new List<Feedback>();


        /*==========ADD feedback to the database==========*/
        public void AddFeedback(int teacherID, int studentID, DateTime date, string course,string feedback, string type, int goalID)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "INSERT INTO Feedback (teacherId,studentId,date,course,feedback,type,goalID) VALUES(@teacherId,@studentId,@date,@course,@feedback,@type,@goalID)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherID);
                    cmd.Parameters.AddWithValue("@studentId", studentID);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@goalID", goalID);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            finally { connection.Dispose(); }
        }

        /*==========Get the list of feedback from the database==========*/
        public void GetFeedbackFromDatabase()
        {
            feedbackList.Clear();

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, teacherId, studentId, date,course,feedback,type,goalID FROM Feedback ORDER BY id";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            feedbackList.Add(new Feedback(
                                Convert.ToInt32(dataReader[0].ToString()), // set the ID property of the Feedback object to the first value in the dataReader array, converted to an integer
                                Convert.ToInt32(dataReader[1].ToString()), // set the ID property of the Feedback object to the first value in the dataReader array, converted to an integer
                                Convert.ToInt32(dataReader[2].ToString()), // set the ID property of the Feedback object to the first value in the dataReader array, converted to an integer
                                Convert.ToDateTime(dataReader[3]), // set the Date property of the Feedback object to the fourth value in the dataReader array, converted to a DateTime object
                                dataReader[4].ToString(), // set the Course property of the Feedback object to the fifth value in the dataReader array, as a string
                                dataReader[5].ToString(), // set the GivenFeedback property of the Feedback object to the sixth value in the dataReader array, as a string
                                dataReader[6].ToString(), // set the Type property of the Feedback object to the seventh value in the dataReader array, as a string
                                Convert.ToInt32(dataReader[7].ToString()) // set the Type property of the Feedback object to the seventh value in the dataReader array, as a string
                                ));
                        }
                    }
                }
            }
        }


        /*==========Get a single feedback from the database==========*/
        public Feedback GetSingleFeedbackByID(int id)
        {
            Feedback feedback = new Feedback(0,1,1,new DateTime(2023, 1, 1), "", "", "", 1);

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, teacherId, studentId, date,course,feedback,type FROM Feedback WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            feedback.ID = Int32.Parse(dataReader[0].ToString());
                            feedback.TeacherID = Int32.Parse(dataReader[1].ToString());
                            feedback.StudentID = Int32.Parse(dataReader[2].ToString());
                            feedback.Date = DateTime.Parse(dataReader[3].ToString());
                            feedback.Course = dataReader[4].ToString();
                            feedback.GivenFeedback = dataReader[5].ToString();
                            feedback.Type = dataReader[6].ToString();
                            feedback.GoalID = Int32.Parse(dataReader[6].ToString());
                        }
                    }
                }
            }
            return feedback;
        }

        /*==========Delete a single feedback from the database==========*/
        public void DeleteFeedback(int id)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "DELETE Feedback WHERE id = @id";
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

        /*==========Update a single feedback from the database==========*/
        public void UpdateFeedback(int id, DateTime date, string course, string feedback, string type,int teacherId, int studentId)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "UPDATE Feedback SET id = @id,date = @date,course = @course,feedback= @feedback,type = @type,teacherId= @teacherId,studentId = @studentId WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@course",course );
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    cmd.Parameters.AddWithValue("@type", type);
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
