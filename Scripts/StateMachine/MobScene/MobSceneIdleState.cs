using Godot;
using System;

public partial class MobSceneIdleState : State
{
	public override void StateStart()
    {
        GetNode<Timer>("Timer").Start();
        GD.Randomize();
    }
	private void OnMobSceneTimerTrigger()
    {
        fsm.ChangeTo("Spawn");
    }
}
