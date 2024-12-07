using Godot;
using System;
using System.Collections.Generic;

public partial class EatHotDogState : State
{
	public override void StateStart()
    {
        GD.Print("Eaten Hot Dog");
        rootNode.GetNode<Sprite2D>("Sprite2D").Visible = false;
    }
}
