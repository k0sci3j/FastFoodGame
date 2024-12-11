using Godot;
using System;

public partial class EatVioletSausageState : EatenState
{
public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().SickPoints+=1;
        GD.Print("Eaten Violet Sausage: "+RootNode.GetParent<MobScene>().SickPoints);
    }
}
