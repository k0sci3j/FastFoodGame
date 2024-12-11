using Godot;
using System;

public partial class EatFriesState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=10;
        GD.Print("Eaten Fries: "+RootNode.GetParent<MobScene>().Points);
    }
}
