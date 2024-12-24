using Godot;
using System;

public partial class Mob : Node2D
{
	[Export]
	public float Speed {get; set;}

	public void OnVisibleOnScreenEnabler2dScreenExited()
	{
		QueueFree();
	}
}
