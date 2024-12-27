using Godot;
using System;

public partial class NextLevelState : State
{
    Node scene;
	public override void StateStart()
    {
        base.StateStart();
        scene = RootNode.GetNode<Level>("Level");
        RootNode.RemoveChild(scene);
        RootNode.GetNode<Node2D>("Animation").GetNode<AnimationPlayer>("AnimationPlayer").Play("fatter");
    }

    public void OnAnimationFatterAnimationEnded()
	{
        GameVariables.Instance.CurrentLevel+=1;
        RootNode.AddChild(scene);
        double wait = RootNode.GetNode<Level>("Level").GetNode<MobScene>("MobScene").GetNode<StateMachine>("StateMachine").GetNode<MobSceneIdleState>("Idle").GetNode<Timer>("Timer").WaitTime*100;
        RootNode.GetNode<Level>("Level").GetNode<MobScene>("MobScene").GetNode<StateMachine>("StateMachine").GetNode<MobSceneIdleState>("Idle").GetNode<Timer>("Timer").WaitTime = (wait-2)/100;
        fsm.ChangeTo("LevelState");
	}
}
