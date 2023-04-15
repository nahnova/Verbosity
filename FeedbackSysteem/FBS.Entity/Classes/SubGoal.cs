using System;

public class SubGoal
{
	public int ID { get; set; }

    public int GoalID { get; set; }

    public string Subgoal { get; set; }

	public string Status { get; set; }

	public SubGoal(int iD, int goalId, string subgoal, string status)
	{
		ID = iD;
        GoalID = goalId;
        Subgoal = subgoal;
		Status = status;
	}
}
