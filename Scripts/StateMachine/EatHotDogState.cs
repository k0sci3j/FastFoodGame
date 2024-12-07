using Godot;

public partial class EatHotDogState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Hot Dog");
    }
}
