using Godot;
using System;

public partial class EatShakeState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Shake");
    }
}
