using Godot;
using System;

public partial class EatCHamburgerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Hamburger");
    }
}
