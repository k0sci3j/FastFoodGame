using Godot;
using Godot.Collections;
using System;

public partial class MobScene : Node
{
	[Export]
	public Array<PackedScene> MobScenes {get; set;}
}
