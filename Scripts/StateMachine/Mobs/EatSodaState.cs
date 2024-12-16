using Godot;

public partial class EatSodaState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        RootNode.GetParent<MobScene>().Points+=5;
    }
}
