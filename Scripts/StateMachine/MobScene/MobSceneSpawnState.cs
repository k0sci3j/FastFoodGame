using Godot;
using System;

public partial class MobSceneSpawnState : State
{
	public override void StateStart()
    {
		  base.StateStart();
		  //RootNode.GetNode<Timer>("Timer").Stop();
      GD.Print(this.Name+" StateStart");
      //Node2D mob = MobScene.Instantiate<Mob>();
      PackedScene mobScene = ((MobScene)RootNode).MobScenes[(int)(GD.Randi() % ((MobScene)RootNode).MobScenes.Count)];
      Node2D mob = mobScene.Instantiate<Node2D>();
      GD.Print("Instantiated Mob: "+mob); //Here runs StateStart from Mob
      AddChild(mob);
      GD.Print("Added Mob: "+mob);
      fsm.ChangeTo("Idle");
    }

    public override void StateEnd()
    {
      base.StateEnd();
		  GD.Print("End");
    }
}
