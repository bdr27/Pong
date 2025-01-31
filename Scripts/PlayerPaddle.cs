using Godot;
using System;

public partial class PlayerPaddle : CharacterBody2D
{
	private Vector2 movement = new Vector2();
	//public const float Speed = 300.0f;
	//public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	//public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		movement.Y = 0;
		if(Input.IsKeyPressed(Key.Down)){
			movement.Y  = 5;
		}
		else if(Input.IsKeyPressed(Key.Up)){
			movement.Y  = -5;
		}

		Position += movement;
		MoveAndSlide();
		//MoveAndSlide();
		// Vector2 velocity = Velocity;

		// // Add the gravity.
		// if (!IsOnFloor())
		// 	velocity.Y += gravity * (float)delta;

		// // Handle Jump.
		// if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
		// 	velocity.Y = JumpVelocity;

		// // Get the input direction and handle the movement/deceleration.
		// // As good practice, you should replace UI actions with custom gameplay actions.
		// Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		// if (direction != Vector2.Zero)
		// {
		// 	velocity.X = direction.X * Speed;
		// }
		// else
		// {
		// 	velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		// }

		// Velocity = velocity;
		// MoveAndSlide();
	}
}
