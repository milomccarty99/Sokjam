using Godot;
using System;

public partial class player : Node3D
{
	[Export]
	public float Speed = 15f;
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
		if (Input.IsActionPressed("move_right"))
		{
			GlobalPosition = new Vector3(GlobalPosition.X + Speed * (float)(delta), GlobalPosition.Y, GlobalPosition.Z);
		}
		if (Input.IsActionPressed("move_left"))
		{
			GlobalPosition = new Vector3(GlobalPosition.X - Speed * (float)(delta), GlobalPosition.Y, GlobalPosition.Z);
		}
		if (Input.IsActionPressed("move_forward"))
		{
			GlobalPosition = new Vector3(GlobalPosition.X, GlobalPosition.Y, GlobalPosition.Z - Speed * (float)(delta));
		}
		if (Input.IsActionPressed("move_back"))
		{
			GlobalPosition = new Vector3(GlobalPosition.X, GlobalPosition.Y, GlobalPosition.Z + Speed * (float)(delta));
		}
	}
	
	public override void _Input(InputEvent input)
	{
		
	}
}
