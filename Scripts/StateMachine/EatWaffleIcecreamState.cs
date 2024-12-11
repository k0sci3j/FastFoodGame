using Godot;
using System;

public partial class EatWaffleIcecreamState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=9;
        GD.Print("Eaten Waffle Icecream: "+RootNode.GetParent<MobScene>().Points);
    }
}
