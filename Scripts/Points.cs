using Godot;
using System;

public partial class Points : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		MobScene scene = GetParent().GetNode<MobScene>("MobScene");
		GetNode<RichTextLabel>("Points").Text = "[color=red]"+scene.Points+"[/color]";
		if(scene.SickPoints>=1)
		{
			GetNode<Sprite2D>("Violet0").Visible = true;
		}
		if(scene.SickPoints>=2)
		{
			GetNode<Sprite2D>("Violet1").Visible = true;
		}
		if(scene.SickPoints>=3)
		{
			GetNode<Sprite2D>("Violet2").Visible = true;
		}
		if(scene.SickPoints>=4)
		{
			GetNode<Sprite2D>("Violet3").Visible = true;
		}
		if(scene.SickPoints>=5)
		{
			GetNode<Sprite2D>("Violet4").Visible = true;
		}
		if(scene.SickPoints>=6)
		{
			GetNode<Sprite2D>("Violet5").Visible = true;
		}
	}
}
