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
using FBS.Entity.InventoryProducts;

namespace FBS.Repository
{

    public class StudentsRepo
    {
        private InventoryDBDataAccess iDB{ get; set; }

        public StudentsRepo()
        {
            this.iDB = new InventoryDBDataAccess();
        }
        FeedbackCollectionDBDataAccess()
        public List<Student> students = new List<Student>();

        //Add Student
        public void AddStudent(int iD, string firstName, string lastName, string email, string gender,string password)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "INSERT INTO Student (id,firstName,lastName,email,gender,password) VALUES(@id,@firstName,@lastName,@email,@gender,@password)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", iD);
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

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firstName, lastName, email,gender,password FROM Student ORDER BY id";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            students.Add(new Student(Int32.Parse(Int32.Parse(dataReader[0].ToString()))
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
            Student student = new Product("", "", "", "", "", "");

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firsName, lastName, email, gender,password FROM  WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            student.ID = dataReader[0];
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
    }   
}
