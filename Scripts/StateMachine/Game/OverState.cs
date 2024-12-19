using Godot;
using System;

public partial class OverState : State
{
    Node scene;
	public override void StateStart()
    {
        base.StateStart();
        scene = GetTree().CurrentScene.GetNode<Level>("Level");
        RootNode.RemoveChild(scene);
        RootNode.GetNode<Node2D>("Animation").GetNode<AnimationPlayer>("AnimationPlayer").Play("burp");
    }

    public void OnAnimationBurpAnimationEnded()
	{
        RootNode.AddChild(scene);
        GetTree().ReloadCurrentScene();
        fsm.ChangeTo("LevelState");
	}
}
