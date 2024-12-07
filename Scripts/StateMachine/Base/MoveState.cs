using Godot;

public partial class MoveState : State
{
    private void OnEatZoneBodyEntered(CharacterBody2D body)
    {
        fsm.ChangeTo("EatenState");
        QueueFree();
    }
}
