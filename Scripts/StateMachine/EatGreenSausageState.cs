using Godot;
using System;

public partial class EatGreenSausageState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=1;
    }
}
