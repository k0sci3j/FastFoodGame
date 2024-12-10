using Godot;
using System;

public partial class EatIcecreamState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Icecream");
    }
}
