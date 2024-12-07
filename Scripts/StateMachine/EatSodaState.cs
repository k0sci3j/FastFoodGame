using Godot;

public partial class EatSodaState : EatenState
{
	public override void StateStart()
    {
        base.StateStart();
        GD.Print("Eaten Soda");
    }
}
