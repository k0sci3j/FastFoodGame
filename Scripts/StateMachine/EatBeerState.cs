using Godot;
using System;

public partial class EatBeerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Hot Dog");
    }
}
