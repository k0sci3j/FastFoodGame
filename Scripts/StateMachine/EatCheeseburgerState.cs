using Godot;
using System;

public partial class EatCheeseburgerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=20;
    }
}
