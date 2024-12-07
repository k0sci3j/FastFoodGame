using Godot;
using System;

public partial class SickZone : Area2D
{
	private void OnBodyEntered(CharacterBody2D body)
    {
        GD.Print("Sick: "+body.Name+" "+this.GetNode("..").Name);
        this.GetNode("..").GetNode<Sprite2D>("Sprite2D").Visible=false;
        QueueFree();
    }
}
