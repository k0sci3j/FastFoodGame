using Godot;

public partial class MoveState : State
{
    public override void StateStart()
    {
        GD.Print("Mob Move Start");
    }
    private void OnEatZoneBodyEntered(CharacterBody2D body)
    {
        fsm.ChangeTo("EatenState");
        QueueFree();
    }
}
