using Godot;
using System;

public partial class Animation : Node2D
{
	[Signal]
	public delegate void BurpAnimationEndedEventHandler();
	[Signal]
	public delegate void FatterAnimationEndedEventHandler();

	public void OnAnimationPlayerAnimationFinished(StringName n)
	{
		if(n.Equals("fatter"))
		{
			EmitSignal(SignalName.FatterAnimationEnded);
		}
		if(n.Equals("burp"))
		{
			EmitSignal(SignalName.BurpAnimationEnded);
		}
	}

}
