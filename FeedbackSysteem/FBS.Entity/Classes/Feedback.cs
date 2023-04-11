using System;

public class Feedback
{
	public int ID { get; set; }

    public DateTime Date { get; set; }

    public string Course { get; set; }

	public string Feedback { get; set; }

	public string Type { get; set; }

	public Teacher SingleTeacher { get; set; }

	public Student SingleStudent { get; set; }

	public Feedback(int iD, DateTime date, string course, string feedback, string type, Teacher teacher, Student student )
	{
		ID = iD;
		Date = date;
		Course = course;
		Feedback = feedback;
		Type = type;
		SingleTeacher = teacher;
		SingleStudent = student;
	}
}
