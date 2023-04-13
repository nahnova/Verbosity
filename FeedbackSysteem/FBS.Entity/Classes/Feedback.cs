using System;

public class Feedback
{
	public int ID { get; set; }

    public DateTime Date { get; set; }

    public string Course { get; set; }

	public string GivenFeedback { get; set; }

	public string Type { get; set; }

	public Teacher SingleTeacher { get; set; }

	public Student SingleStudent { get; set; }

	public Feedback(int iD, DateTime date, string course, string feedback, string type, Teacher teacher, Student student )
	{
		ID = iD;
		Date = date;
		Course = course;
		GivenFeedback = feedback;
		Type = type;
		SingleTeacher = teacher;
		SingleStudent = student;
	}
}
