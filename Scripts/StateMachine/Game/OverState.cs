using Godot;

public partial class OverState : State
{
    Node scene;
	public override void StateStart()
    {
        base.StateStart();
        scene = GetTree().CurrentScene.GetNode<Level>("Level");
        GameVariables.Instance.LastPoints = ((Level)scene).Points;
        RootNode.RemoveChild(scene);
        RootNode.GetNode<Node2D>("Animation").GetNode<AnimationPlayer>("AnimationPlayer").Play("burp");
        RootNode.GetNode<Node2D>("Animation").GetNode<AudioStreamPlayer2D>("BurpSound").Play();
    }

    public void OnAnimationBurpAnimationEnded()
	{
        PackedScene score = GD.Load<PackedScene>("res://Scenes/start.tscn");
        GetTree().ChangeSceneToPacked(score);
	}
}
