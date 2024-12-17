using Godot;
using Godot.Collections;
using System;

public partial class OverState : State
{
	public override void StateStart()
    {
        base.StateStart();
		// RootNode.GetNode<MobScene>("MobScene").GetNode<StateMachine>("StateMachine").GetNode<MobSceneIdleState>("Idle").GetNode<Timer>("Timer").Stop();
        // Array<Node> mobs = RootNode.GetNode<Node2D>("Level").GetNode<MobScene>("MobScene").GetChildren();
        // GD.Print(mobs);
        RootNode.RemoveChild(RootNode.GetNode<Level>("Level"));
        RootNode.GetNode<Node2D>("Burp").GetNode<AnimationPlayer>("AnimationPlayer").Play("down");
    }
}
