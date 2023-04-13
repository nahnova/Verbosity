using System;
using System.Collections.Generic;
public class Teacher
{
	public int ID { get; set; }

	public string FirstName { get; set; }

	public string LastName { get; set; }

	public string Email { get; set; }

	public string Phone { get; set; }

	public List<Feedback> Feedback { get; set; }

	public List<Group> Group { get; set; }

	public Teacher(int iD, string firstName, string lastName, string email, string phone)
	{
		ID = iD;
		FirstName = firstName;
		LastName = lastName;
		Email = email;
		Phone = phone;
	}
}
