using Godot;
using System;

public partial class LevelState : State
{
	public void OnLevelGameOver()
	{
		fsm.ChangeTo("OverState");
		QueueFree();
	}
}
