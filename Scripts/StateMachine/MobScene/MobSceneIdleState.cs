using Godot;
using System;

public partial class MobSceneIdleState : State
{
	public override void StateStart()
    {
        RootNode.GetNode<Timer>("Timer").Start();
    }
	private void OnMobSceneTimerTrigger()
    {
        GD.Print("Mob Scene Timer: "+((MobScene)RootNode).MobScenes);
    }
}
