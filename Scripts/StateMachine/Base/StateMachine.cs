using Godot;
using System.Collections.Generic;

public partial class StateMachine : Node
{
    [Export]
    public NodePath InitialState {get; set;}
    [Export]
    public Node RootNode {get; set;}
    private Dictionary<string, State> _states;
    private State _lastState;
    private State _currentState;
    public override void _Ready()
    {
        _states = new Dictionary<string, State>();
        foreach(Node n in GetChildren())
        {
            if (n is State s) 
            {
                _states[n.Name] = s;
                s.fsm = this;
                //s.Ready();
                //s.StateEnd();
            }
        }
        _currentState = GetNode<State>(InitialState);
        _currentState.StateStart();
    }

    public override void _Process(double delta)
    {
        _currentState.Update((float)delta);
    }
    public override void _PhysicsProcess(double delta)
    {
        _currentState.PhysicsUpdate((float)delta);
    }
    public override void _UnhandledInput(InputEvent @event)
    {
        _currentState.HandleInput(@event);
    }

    public void ChangeTo(string key)
    {
        if(!_states.ContainsKey(key) || _currentState == _states[key])
            return;
        _currentState.StateEnd();
        _lastState = _currentState;
        _currentState = _states[key];
        _currentState.StateStart();
    }
}
