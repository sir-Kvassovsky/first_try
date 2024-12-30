using Godot;
using System;

public partial class MySprite2D : Sprite2D
{
	private int _speed = 400;
	private float _angularSpeed = Mathf.Pi;
	private void OnButtonPressed()	
	{
		SetProcess(!IsProcessing());
	}
	public override void _Process(double delta)
	{
		var direction = 0;
		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("ui_up"))
		{
			velocity = Vector2.Up.Rotated(Rotation) * _speed;
		}
		if (Input.IsActionPressed("ui_left"))
		{
			direction = -1;
		}
		if (Input.IsActionPressed("ui_right"))
		{
			direction = 1;
		}

		Rotation += _angularSpeed * direction * (float)delta;
		Position += velocity * (float)delta;
	}

}
