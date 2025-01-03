using Godot;

public partial class MoveState : State
{
    public override void PhysicsUpdate(float delta)
    {
        Vector2 velocity = new Vector2(1,0);
        ((Mob)RootNode).Translate(delta * velocity * ((((Mob)RootNode).Speed)+(GameVariables.Instance.CurrentLevel*4)));
    }
    private void OnEatZoneBodyEntered(CharacterBody2D body)
    {
        fsm.ChangeTo("EatenState");
        QueueFree();
    }
}
