using Godot;

public partial class EatHotDogState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=5;
        GD.Print("Eaten Hot Dog: "+RootNode.GetParent<MobScene>().Points);
    }
}
