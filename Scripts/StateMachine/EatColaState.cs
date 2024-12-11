using Godot;
using System;

public partial class EatColaState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=4;
        GD.Print("Eaten Cola: "+RootNode.GetParent<MobScene>().Points);
    }
}
