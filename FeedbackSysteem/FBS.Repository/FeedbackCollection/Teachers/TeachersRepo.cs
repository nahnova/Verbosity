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
        // The iDB property provides access to the FeedbackCollectionDBDataAccess object, which provides access to the database connection string
        private FeedbackCollectionDBDataAccess iDB { get; set; }

        // The teachers property contains all the Teacher objects retrieved from the database
        public List<Teacher> teachers { get; set; }

        // Constructor that initializes the FeedbackCollectionDBDataAccess object and the teachers list
        public TeachersRepo()
        {
            // Create a new FeedbackCollectionDBDataAccess object and assign it to the iDB property
            this.iDB = new FeedbackCollectionDBDataAccess();

            // Create a new List<Teacher> object and assign it to the teachers property
            this.teachers = new List<Teacher>();
        }

        // Add a new teacher to the database with the given details
        public void AddTeacher(int iD, string firstName, string lastName, string email, int phone)
        {
            // Create a new SqlConnection object to connect to the database
            SqlConnection connection = new SqlConnection();

            try
            {
                // Set the connection string for the SQL Server database
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;

                // Open the database connection
                connection.Open();

                // Define the SQL statement to insert a new teacher
                string sql = "INSERT INTO Teacher (id,firstName,lastName,email,phone) VALUES(@id,@firstName,@lastName,@email,@phone)";

                // Create a SqlCommand object with the SQL statement and the database connection
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // Add parameters to the SqlCommand object for the new teacher's details
                    cmd.Parameters.AddWithValue("@id", iD);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    // Execute the SQL statement to insert the new teacher
                    cmd.ExecuteNonQuery();
                }

                // Close the database connection
                connection.Close();
            }
            catch (Exception ex)
            {
                // If there is an exception, throw it to the calling method
                throw ex;
            }
            finally
            {
                // Always dispose the database connection, even if an exception is thrown
                connection.Dispose();
            }
        }


        // Get the list of teachers from the database
        public void GetTeachersFromDatabase()
        {
            // Clear the existing teachers list
            teachers.Clear();

            // Create a new SqlConnection object with the connection string from the iDB.Sqlcon object
            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                // Create a new SqlCommand object to execute the SQL query
                using (SqlCommand cmd = new SqlCommand())
                {
                    // Set the SqlConnection object for the SqlCommand object
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;

                    // Open the database connection
                    cnn.Open();

                    // Set the SqlCommand object's SqlConnection object and the SQL query to retrieve the list of teachers' details
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firstName, lastName, email, phone, password FROM Teacher ORDER BY id";

                    // Execute the SQL query and retrieve the results in a SqlDataReader object
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        // If there is at least one row in the SqlDataReader object, create a new Teacher object with the retrieved details and add it to the teachers list
                        while (dataReader.Read())
                        {
                            teachers.Add(new Teacher(
                                Int32.Parse((dataReader[0].ToString())),
                                dataReader[1].ToString(),
                                dataReader[2].ToString(),
                                dataReader[3].ToString(),
                                dataReader[4].ToString(),
                                dataReader[5].ToString()
                            ));
                        }
                    }
                }
            }
        }


        // This method retrieves a single teacher's details from the database based on the teacher's ID
        public Teacher GetSingleTeacherByID(int id)
        {
            // Create a new Teacher object with default values
            Teacher teacher = new Teacher(0, "", "", "", "", "");

            // Create a new SqlConnection object with the connection string from the iDB.Sqlcon object
            using (SqlConnection cnn = new SqlConnection(iDB.Sqlcon.ConnectionString))
            {
                // Create a new SqlCommand object to execute the SQL query
                using (SqlCommand cmd = new SqlCommand())
                {
                    // Set the SqlConnection object for the SqlCommand object
                    cnn.ConnectionString = iDB.Sqlcon.ConnectionString;

                    // Open the database connection
                    cnn.Open();

                    // Set the SqlCommand object's SqlConnection object and the SQL query to retrieve the teacher's details
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT id, firstName, lastName, email,phone FROM Teacher WHERE id = @id";

                    // Add a parameter for the teacher's ID to the SqlCommand object
                    cmd.Parameters.AddWithValue("@id", id);

                    // Execute the SQL query and retrieve the results in a SqlDataReader object
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        // If there is at least one row in the SqlDataReader object, retrieve the teacher's details
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

            // Return the Teacher object with the retrieved details
            return teacher;
        }


        // This method updates the details of a teacher with the given ID in the database
        public void UpdateTeacher(int id, string firstName, string lastName, string email, string phone)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                // Set the connection string for the SQL Server database
                connection.ConnectionString = iDB.Sqlcon.ConnectionString;

                // Open the database connection
                connection.Open();

                // Define the SQL statement to update the teacher details
                string sql = "UPDATE Teacher SET firstName = @firstname,lastName = @lastName,email = @email,phone = @phone WHERE id = @id";

                // Create a SqlCommand object with the SQL statement and the database connection
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    // Add parameters to the SqlCommand object for the teacher ID and the updated details
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    // Execute the SQL statement to update the teacher details
                    cmd.ExecuteNonQuery();
                }

                // Close the database connection
                connection.Close();
            }
            catch (SqlException ex)
            {
                // If there is an exception, throw it to the calling method
                throw ex;
            }
            finally
            {
                // Always dispose the database connection, even if an exception is thrown
                connection.Dispose();
            }
        }
    }
}
