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
    public class TeachersRepo
    {
        private FeedbackCollectionDBDataAccess iDB { get; set; }
        public List<Teacher> teachers { get; set; }

        public TeachersRepo()
        {
            this.iDB = new FeedbackCollectionDBDataAccess();
            this.teachers = new List<Teacher>();
        }

        // Add Teacher
        public void AddTeacher(int iD, string firstName, string lastName, string email, int phone)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;
                connection.Open();
                string sql = "INSERT INTO Teacher (id,firstName,lastName,email,phone) VALUES(@id,@firstName,@lastName,@email,@phone)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", iD);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex) { throw ex; }
            finally { connection.Dispose(); }
        }

        // Get the list of teachers from the database
        public void GetTeachersFromDatabase()
        {
            teachers.Clear();

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firstName, lastName, email,phone FROM Teacher ORDER BY id";

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            teachers.Add(new Teacher(
                                Int32.Parse((dataReader[0].ToString())),
                                dataReader[1].ToString(),
                                dataReader[2].ToString(),
                                dataReader[3].ToString(),
                                dataReader[4].ToString()
                            ));
                        }
                    }
                }
            }
        }

        // Get a single student from the database
        public Teacher GetSingleTeacherByID(int id)
        {
            Teacher teacher = new Teacher(0, "", "", "", "");

            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firsName, lastName, email,phone FROM  Teacher WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            teacher.ID = Int32.Parse(dataReader[0].ToString());
                            teacher.FirstName = dataReader[1].ToString();
                            teacher.LastName = dataReader[2].ToString();
                            teacher.Email = dataReader[3].ToString();
                            teacher.Phone = dataReader[4].ToString();
                        }
                    }
                }
            }
            return teacher;
        }
    }
}
