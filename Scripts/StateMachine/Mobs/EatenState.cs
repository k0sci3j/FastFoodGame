using Godot;

public partial class EatenState : State
{
	public override void StateStart()
    {
        RootNode.GetNode<Sprite2D>("Sprite2D").Visible = false;
        GetTree().CurrentScene.GetNode<Level>("Level").GetNode<AudioStreamPlayer2D>("EatSound").Play();
    }
}
