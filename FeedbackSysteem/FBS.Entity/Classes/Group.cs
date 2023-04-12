using System;

public class Group
{
	public int ID { get; set; }

	public int TeacherID { get; set; }

	public int StudentID { get; set; }

	public string Name { get; set; }

	public List<Student> ListOfStudent = new List<Student>();
	
	public Group(int iD, int teacherID, int studentID, string name, List<Student> student)
	{
		ID = iD;
		TeacherID = teacherID;
		StudentID = studentID;
		Name = name;
		ListOfStudent = student;
	}
	public void AddStudentToGroup(Student student)
	{
		ListOfStudent.Add(student);
	}
}
