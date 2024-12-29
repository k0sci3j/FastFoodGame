using Godot;
using System;

public partial class Level : Node2D
{
	[Signal]
	public delegate void GameOverEventHandler();
	[Signal]
	public delegate void NextLevelEventHandler();
	public int Points = 0;
	private int LastPoints = 0;
	public int SickPoints=0;
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GetNode<RichTextLabel>("Points").Text = "[color=red]"+Points+"[/color]";
		GetNode<RichTextLabel>("Lvl").Text = "[color=red]"+GameVariables.Instance.CurrentLevel+"[/color]";
		if((Points/100-LastPoints/100)==1)
		{
			EmitSignal(nameof(SignalName.NextLevel));
		}
		LastPoints = Points;
		if(SickPoints>=1)
		{
			GetNode<Sprite2D>("Violet0").Visible = true;
		}
		if(SickPoints>=2)
		{
			GetNode<Sprite2D>("Violet1").Visible = true;
		}
		if(SickPoints>=3)
		{
			GetNode<Sprite2D>("Violet2").Visible = true;
		}
		if(SickPoints>=4)
		{
			GetNode<Sprite2D>("Violet3").Visible = true;
		}
		if(SickPoints>=5)
		{
			GetNode<Sprite2D>("Violet4").Visible = true;
		}
		if(SickPoints>=6)
		{
			GetNode<Sprite2D>("Violet5").Visible = true;
			EmitSignal(nameof(SignalName.GameOver));
		}
	}
}
