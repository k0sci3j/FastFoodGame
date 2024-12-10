using Godot;
using System;

public partial class EatFriesState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Fries");
    }
}
