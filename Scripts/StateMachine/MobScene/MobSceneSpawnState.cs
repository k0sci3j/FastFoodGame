using Godot;
using System;

public partial class MobSceneSpawnState : State
{
	public override void StateStart()
    {
		  base.StateStart();
      PackedScene mobScene = ((MobScene)RootNode).MobScenes[(int)(GD.Randi() % ((MobScene)RootNode).MobScenes.Count)];
      Vector2 m0 = RootNode.GetNode<Marker2D>("Marker2D_up").Position;
      Vector2 m1 = RootNode.GetNode<Marker2D>("Marker2D_down").Position;
      Vector2 position = new Vector2(0, GD.Randi() % m1.Y + m0.Y);
      Node2D mob = mobScene.Instantiate<Node2D>();
      mob.Position = position;
      RootNode.AddChild(mob);
      fsm.ChangeTo("Idle");
    }
}
