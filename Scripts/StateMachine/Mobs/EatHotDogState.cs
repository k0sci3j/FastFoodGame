using Godot;

public partial class EatHotDogState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().GetParent<Level>().Points+=5;
    }
}
