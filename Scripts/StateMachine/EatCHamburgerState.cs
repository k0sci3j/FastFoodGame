using Godot;
using System;

public partial class EatCHamburgerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=6;
        GD.Print("Eaten Hamburger: "+RootNode.GetParent<MobScene>().Points);
    }
}
