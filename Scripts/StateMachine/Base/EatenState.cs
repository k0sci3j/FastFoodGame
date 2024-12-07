using Godot;

public partial class EatenState : State
{
	public override void StateStart()
    {
        rootNode.GetNode<Sprite2D>("Sprite2D").Visible = false;
    }
}
