using System;
using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public float Speed = 400.0f;
	public AnimatedSprite2D playerSprite;

    public override void _Ready()
    {
        base._Ready();
		playerSprite = GetNode<AnimatedSprite2D>("PlayerSprite");
    }
    public override void _PhysicsProcess(double delta)
	{
		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("left"))
		{
			velocity.X -= 1;
			playerSprite.FlipH = false;
		}
		if (Input.IsActionPressed("right"))
		{
			velocity.X += 1;
			playerSprite.FlipH = true;
		}
		if (Input.IsActionPressed("up"))
		{
			velocity.Y -= 1;
		}
		if (Input.IsActionPressed("down"))
		{
			velocity.Y += 1;
		}
		if(velocity.Length() > 0)
		{
			velocity = velocity.Normalized() * Speed;
		}
        Velocity = velocity;
		MoveAndSlide();
	}
}
