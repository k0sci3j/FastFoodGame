using Godot;
using System;

public partial class EatVioletSausageState : EatenState
{
public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Violet Sausage");
    }
}
