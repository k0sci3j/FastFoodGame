using Godot;
using System;

public partial class NextLevelState : State
{
    Node scene;
	public override void StateStart()
    {
        base.StateStart();
        scene = GetTree().CurrentScene.GetNode<Level>("Level");
        RootNode.RemoveChild(scene);
        RootNode.GetNode<Node2D>("Animation").GetNode<AnimationPlayer>("AnimationPlayer").Play("fatter");
    }

    public void OnAnimationFatterAnimationEnded()
	{
        // TODO: Add Mobs Speed increase and Spawn Timer increase if needed
        RootNode.AddChild(scene);
        fsm.ChangeTo("LevelState");
	}
}
