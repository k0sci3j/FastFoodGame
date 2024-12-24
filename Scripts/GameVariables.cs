using Godot;
using System;

public partial class GameVariables : Node
{
	public static GameVariables Instance { get; private set; }
	public int LastPoints {get; set;}
    public int CurrentLevel {get; set;}
	public override void _Ready()
    {
        CurrentLevel = 1;
        Instance = this;
    } 
}
