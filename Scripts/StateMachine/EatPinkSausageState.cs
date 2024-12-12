using Godot;
using System;

public partial class EatPinkSausageState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=1;
    }
}
