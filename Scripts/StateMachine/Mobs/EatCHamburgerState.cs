using Godot;
using System;

public partial class EatCHamburgerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=6;
    }
}
