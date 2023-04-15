using System;

// This class represents feedback given by a student to a teacher about a course.
public class Feedback
{
    // The ID of the feedback.
    public int ID { get; set; }

    // The date the feedback was given.
    public DateTime Date { get; set; }

    // The name of the course for which the feedback was given.
    public string Course { get; set; }

    // The feedback text provided by the student.
    public string GivenFeedback { get; set; }

    // The type of feedback, e.g. "positive", "negative", "suggestion", etc.
    public string Type { get; set; }

    // The teacher who received the feedback.
    public Teacher SingleTeacher { get; set; }

    // The student who provided the feedback.
    public Student SingleStudent { get; set; }

    // Creates a new instance of Feedback with the given properties.
    public Feedback(int iD, DateTime date, string course, string feedback, string type, Teacher teacher, Student student)
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
