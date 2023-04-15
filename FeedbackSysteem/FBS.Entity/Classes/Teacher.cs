using System;
using System.Collections.Generic;

// This class represents a teacher.
public class Teacher
{
    // The ID of the teacher.
    public int ID { get; set; }

    // The first name of the teacher.
    public string FirstName { get; set; }

    // The last name of the teacher.
    public string LastName { get; set; }

    // The email address of the teacher.
    public string Email { get; set; }

    // The phone number of the teacher.
    public string Phone { get; set; }

    // The password of the teacher.
    public string Password { get; set; }

    // A list of feedback received by the teacher.
    public List<Feedback> Feedback { get; set; }

    // A list of groups led by the teacher.
    public List<Group> Group { get; set; }

    // Creates a new instance of Teacher with the given properties.
    // Note that the feedback and group lists are initially empty.
    public Teacher(int iD, string firstName, string lastName, string email, string phone, string password)
    {
        ID = iD;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Password = password;
    }
}

