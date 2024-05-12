using Godot;
using System;

public partial class PlayerPaddle_old : Control
{
	Vector2 movement = new Vector2();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
        
    //var xVelocity = 0;
    	movement.Y = 0;
		if(Input.IsKeyPressed(Key.Down)){
			movement.Y  = 5;
		}
		else if(Input.IsKeyPressed(Key.Up)){
			movement.Y  = -5;
		}

		Position += movement;
        //base._PhysicsProcess(delta);
	}
}
