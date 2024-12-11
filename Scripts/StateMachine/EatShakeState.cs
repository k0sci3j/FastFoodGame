using Godot;
using System;

public partial class EatShakeState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=7;
        GD.Print("Eaten Shake: "+RootNode.GetParent<MobScene>().Points);
    }
}
