using System;
using System.Collections.Generic;

// This class represents a student.
public class Student
{
    // The ID of the student.
    public int ID { get; set; }

    // The first name of the student.
    public string FirstName { get; set; }

    // The last name of the student.
    public string LastName { get; set; }

    // The email address of the student.
    public string Email { get; set; }

    // The gender of the student.
    public string Gender { get; set; }

    // The password of the student.
    public string Password { get; set; }

    // A list of feedback given by the student.
    public List<Feedback> Feedback { get; set; }

    // A list of goals set by the student.
    public List<Goal> Goal { get; set; }

    // A list of groups the student belongs to.
    public List<Group> Group { get; set; }

    // Creates a new instance of Student with the given minimal properties.
    public Student(int iD, string firstName, string lastName, string email, string gender, string password)
    {
        ID = iD;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Gender = gender;
        Password = password;
    }
}

