using Godot;
using System;

public partial class EatPinkSausageState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Pink Sausage");
    }
}
