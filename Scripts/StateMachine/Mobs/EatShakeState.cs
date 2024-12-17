using Godot;
using System;

public partial class EatShakeState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().GetParent<Level>().Points+=7;
    }
}
