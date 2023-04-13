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
using IMS.DataAccess;
using IMS.Entity.InventoryProducts;

namespace IMS.Repository
{

    public class FeedbackRepo
    {
        private InventoryDBDataAccess iDB{ get; set; }

        public FeedbackRepo()
        {
            this.iDB = new InventoryDBDataAccess();
        }
        public List<Feedback> feedbackList = new List<Feedback>();

        //Add Student
        public void AddFeedback(int id, int teacherID, int studentID, DateTime date, string course,string feedback, string type)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "INSERT INTO Feedback (id,teacherId,studentId,date,course,feedback,type) VALUES(@id,@teacherId,@studentId,@date,@course,@feedback,@type)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@teacherId", teacherID);
                    cmd.Parameters.AddWithValue("@studentId", studentID);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@course", course);
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            finally { connection.Dispose(); }
        }

        /*==========Get the list of students from the database==========*/
        public void GetFeedbackFromDatabase()
        {
            feedbackList.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, teacherId, studentId, date,course,feedback,type FROM Feedback ORDER BY id";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            feedbackList.Add(new Feedback(Int32.Parse(Int32.Parse(dataReader[0].ToString()))
                                                               , Int32.Parse(dataReader[1].ToString())
                                                               , Int32.Parse(dataReader[2].ToString())
                                                               , DateTime.Parse(dataReader[3].ToString())
                                                               , dataReader[4].ToString()
                                                               , dataReader[5].ToString()
                                                               , dataReader[6].ToString()
                                                               )
                                        );
                        }
                    }
                }
            }
        }

        /*==========Get a single student from the database==========*/
        public Feedback GetSinglestudentByID(int id)
        {
            Feedback feedback = new Feedback(0, 0, 0, 01-01-2023, "", "","");

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, teacherId, studentId, date,course,feedback,type FROM Feedback WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            feedback.ID = Int32.Parse(dataReader[0].ToString());
                            feedback.Date = DateTime.Parse(dataReader[3].ToString());
                            feedback.Course = dataReader[4].ToString();
                            feedback.Feedback = dataReader[5].ToString();
                            feedback.Type = dataReader[6].ToString();
                            feedback.SingleTeacher.ID = Int32.Parse(dataReader[1].ToString());
                            feedback.SingleStudent,ID = Int32.Parse(dataReader[2].ToString());
                           
                        }
                    }
                }
            }
            return feedback;
        }

        //Delete Feedback
        public void DeleteFeedback(int id)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
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

        // Update feedback
        public void UpdateFeedback(int id, DateTime date, string course, string feedback, string type,int teacherId, int studentId)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "UPDATE Feedback SET id = @id,date = @date,course = @course,feedback= @feedback,type = @type,teacherId= @teacherId,studentId = @studentId WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@course",course );
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
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
