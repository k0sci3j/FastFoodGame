using Godot;
using System;
using System.Collections.Generic;

public partial class MoveState : State
{
    private void OnEatZoneBodyEntered(CharacterBody2D body)
    {
        fsm.ChangeTo("EatenState");
        QueueFree();
    }
}
