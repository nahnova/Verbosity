using System;

public class SubGoal
{
	public int ID { get; set; }

	public string Subgoal { get; set; }

	public Goal SingleGoal { get; set; }
	
	public SubGoal(int iD, Goal goal, string subgoal)
	{
		ID = iD;
		SingleGoal = goal;
		Subgoal = subgoal;
	}
}
