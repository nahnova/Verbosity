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

    public class StudentsRepo
    {
        private FeedbackCollectionDBDataAccess iDB{ get; set; }

        public StudentsRepo()
        {
            this.iDB = new FeedbackCollectionDBDataAccess();
        }

        public List<Student> students = new List<Student>();
        //Add Student
        public void AddStudent(string firstName, string lastName, string email, string gender,string password)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "INSERT INTO Student (firstName,lastName,email,gender,password) VALUES(@firstName,@lastName,@email,@gender,@password)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            finally { connection.Dispose(); }
        }
        
        /*==========Get the list of students from the database==========*/
        public void GetStudentsFromDatabase()
        {
            students.Clear();

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firstName, lastName, email,gender,password FROM Student ORDER BY id";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            students.Add(new Student(Int32.Parse((dataReader[0].ToString()))
                                                               , dataReader[1].ToString()
                                                               , dataReader[2].ToString()
                                                               , dataReader[3].ToString()
                                                               , dataReader[4].ToString()
                                                               , dataReader[5].ToString()
                                                               )
                                        );
                        }
                    }
                }
            }
        }

        /*==========Get a single student from the database==========*/
        public Student GetSinglestudentByID(int id)
        {
            Student student = new Student(0, "", "", "", "", "");

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firstName, lastName, email, gender, password FROM Student WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            student.ID = Int32.Parse(dataReader[0].ToString());
                            student.FirstName = dataReader[1].ToString();
                            student.LastName = dataReader[2].ToString();
                            student.Email = dataReader[3].ToString();
                            student.Gender = dataReader[4].ToString();
                            student.Password = dataReader[5].ToString();
                        }
                    }
                }
            }
            return student;
        }

        public void UpdateStudent(int id, string firstName, string lastName, string email, string gender)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "UPDATE Student SET firstName = @firstname,lastName = @lastName,email = @email,gender = @gender WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@gender", gender);
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
