using Godot;
using System;

public partial class LevelState : State
{
	public override void StateStart()
	{
		base.StateStart();
	}
    public void OnLevelGameOver()
	{
		fsm.ChangeTo("OverState");
	}
	public void OnLevelNextLevel()
	{
		fsm.ChangeTo("NextLevelState");
	}
}
