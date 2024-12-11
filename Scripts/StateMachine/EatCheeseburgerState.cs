using Godot;
using System;

public partial class EatCheeseburgerState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=20;
        GD.Print("Eaten Cheeseburger: "+RootNode.GetParent<MobScene>().Points);
    }
}
