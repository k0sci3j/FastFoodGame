using Godot;
using System;

public partial class EatPizzaState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=10;
    }
}
