using Godot;
using System;

public partial class EatIcecreamState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=7;
    }
}
