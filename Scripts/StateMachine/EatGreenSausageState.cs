using Godot;
using System;

public partial class EatGreenSausageState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Green Sausage");
    }
}
