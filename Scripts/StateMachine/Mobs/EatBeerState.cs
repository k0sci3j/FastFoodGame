using Godot;
using System;

public partial class EatBeerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=3;
    }
}
