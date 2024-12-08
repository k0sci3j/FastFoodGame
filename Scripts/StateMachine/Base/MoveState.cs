using Godot;

public partial class MoveState : State
{
    public override void StateStart()
    {
        GD.Print("Mob Move Start");
        ((Node2D)RootNode).Visible = false;
    }
    private void OnEatZoneBodyEntered(CharacterBody2D body)
    {
        fsm.ChangeTo("EatenState");
        QueueFree();
    }
}
