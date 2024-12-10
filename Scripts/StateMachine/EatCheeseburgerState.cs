using Godot;
using System;

public partial class EatCheeseburgerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Cheeseburger");
    }
}
