using Godot;
using Godot.Collections;

public partial class MobScene : Node
{
	[Export]
	public Array<PackedScene> MobScenes {get; set;}
}
