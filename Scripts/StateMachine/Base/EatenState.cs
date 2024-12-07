using Godot;
using System;
using System.Collections.Generic;

public partial class EatenState : State
{
	public override void StateStart()
    {
        GD.Print("Eaten");
        rootNode.GetNode<Sprite2D>("Sprite2D").Visible = false;
    }
}
