using Godot;
using System;

public partial class PointsLabel : RichTextLabel
{
	public override void _Process(double delta)
	{
		Text = "[color=red]"+GetParent().GetParent().GetNode<MobScene>("MobScene").Points+"[/color]";
	}
}
