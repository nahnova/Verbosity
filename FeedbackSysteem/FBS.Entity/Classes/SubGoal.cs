using System;

public class SubGoal
{
	public int ID { get; set; }

	public string Subgoal { get; set; }

	public Goal SingleGoal { get; set; }
	
	public SubGoal(int iD, int goalID, string subgoal, Goal goal)
	{
		ID = iD;
		GoalID = goalID;
		Subgoal = subgoal;
		SingleGoal = goal;
	}
}
