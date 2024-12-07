using Godot;
using System;
using System.Collections.Generic;

public partial class EatSodaState : State
{
	public override void StateStart()
    {
        GD.Print("Eaten Soda");
        rootNode.GetNode<Sprite2D>("Sprite2D").Visible = false;
    }
}
