using Godot;
using System;

public partial class Start : Node2D
{
    public override void _Process(double delta)
    {
        GetNode<RichTextLabel>("Points").Text = GameVariables.Instance.LastPoints.ToString();
		GetNode<RichTextLabel>("Lvl").Text = GameVariables.Instance.CurrentLevel.ToString();
    }
    public override void _Input(InputEvent @event)
    {
        if(@event.IsPressed())
        {
			PackedScene scene = GD.Load<PackedScene>("res://Scenes/game.tscn");
			GetTree().ChangeSceneToPacked(scene);
        }
    }
}
