using Godot;
using System;

public partial class EatColaState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=4;
    }
}
