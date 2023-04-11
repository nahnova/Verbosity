using System;

public class Student
{
	public int ID { get; set; }

	public string FirstName { get; set; }

	public string LastName { get; set; }

	public string Email { get; set; }

	public string Gender { get; set; }

	public string Password { get; set; }

	public List<Feedback> Feedback { get; set; }

	public List<Goal> Goal { get; set; }

	public List<Group> Group { get; set; }

	// This constructor contains only the minimal required parameters to create a student object
	public Student(int iD, string firstName, string lastName, string email, string gender, string password)
	{
		ID = iD;
		FirstName = firstName;
		LastName = lastName;
		Email = email;
		Gender = gender;
		Password = password;
	}
    
	
