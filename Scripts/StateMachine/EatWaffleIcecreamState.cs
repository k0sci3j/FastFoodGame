using Godot;
using System;

public partial class EatWaffleIcecreamState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Waffle Icecream");
    }
}
