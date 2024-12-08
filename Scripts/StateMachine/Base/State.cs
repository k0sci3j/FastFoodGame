using Godot;

public partial class State : Node
{
	[Signal]
	public delegate void StateStartedEventHandler();
	[Signal]
	public delegate void StateUpdatedEventHandler();
	[Signal]
	public delegate void StateEndedEventHandler();
	public StateMachine fsm;
	public Node RootNode;
    public override void _Ready()
    {
        base._Ready();
		RootNode = GetParent<StateMachine>().RootNode;
    }
    public virtual void StateStart()
	{
		EmitSignal(nameof(SignalName.StateStarted));
	}
	public virtual void StateEnd() 
	{
		EmitSignal(nameof(SignalName.StateEnded));
	}

	public new virtual void Ready() {}
	public virtual void Update(float delta) {}
	public virtual void PhysicsUpdate(float delta) {}
	public virtual void HandleInput(InputEvent @event) {}
}
