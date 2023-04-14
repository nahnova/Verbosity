using System;

public class SubGoal
{
	public int ID { get; set; }

    public int GoalID { get; set; }

    public string Subgoal { get; set; }

	public SubGoal(int iD, int goalId, string subgoal)
	{
		ID = iD;
        GoalID = goalId;
        Subgoal = subgoal;
	}
}
