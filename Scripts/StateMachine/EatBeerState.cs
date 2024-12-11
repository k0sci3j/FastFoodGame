using Godot;
using System;

public partial class EatBeerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=3;
        GD.Print("Eaten Beer: "+RootNode.GetParent<MobScene>().Points);
    }
}
