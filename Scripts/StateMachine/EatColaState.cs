using Godot;
using System;

public partial class EatColaState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Cola");
    }
}
