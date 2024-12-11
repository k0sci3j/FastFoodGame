using Godot;
using Godot.Collections;
using System;

public partial class MobScene : Node
{
	[Export]
	public Array<PackedScene> MobScenes {get; set;}
	public int Points=0;
	public int SickPoints=0;
}
