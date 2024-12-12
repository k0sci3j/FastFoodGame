using Godot;
using System;

public partial class EatVioletSausageState : EatenState
{
public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().SickPoints+=1;
    }
}
