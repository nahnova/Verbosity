using System;
using System.Collections.Generic;

// This class represents a group of students led by a teacher.
public class Group
{
    // The ID of the group.
    public int ID { get; set; }

    // The ID of the teacher who leads the group.
    public int TeacherID { get; set; }

    // The ID of the student who serves as the representative of the group.
    public int StudentID { get; set; }

    // The name of the group.
    public string Name { get; set; }

    // A list of students in the group.
    public List<Student> ListOfStudent = new List<Student>();

    // Creates a new instance of Group with the given properties and list of students.
    public Group(int iD, int teacherID, int studentID, string name, List<Student> student)
    {
        ID = iD;
        TeacherID = teacherID;
        StudentID = studentID;
        Name = name;
        ListOfStudent = student;
    }

    // Adds a new student to the group.
    public void AddStudentToGroup(Student student)
    {
        ListOfStudent.Add(student);
    }
}
