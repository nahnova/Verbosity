using System;
using System.Collections.Generic;

public class Goal
{
	public int ID { get; set; }

	public int StudentID { get; set; }

	public string Priority { get; set; }

	public string CreatedGoal { get; set; }

	public string Time { get; set; }

    public List<SubGoal> ListOfSubGoal = new List<SubGoal>();

	// This goal contains no subgoals
    public Goal(int iD, int studentID, string priority, string goal, string time)
	{
		ID = iD;
		StudentID = studentID;
		Priority = priority;
		CreatedGoal = goal;
		Time = time;
	}

}
