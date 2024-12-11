using Godot;
using System;

public partial class EatIcecreamState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=7;
        GD.Print("Eaten Icecream: "+RootNode.GetParent<MobScene>().Points);
    }
}
