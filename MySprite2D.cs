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

    public override void _Ready()
    {
		var timer = GetNode<Timer>("Timer");
		timer.Timeout += OnTimerTimeout;
    }

	private void OnTimerTimeout()
	{
		Visible = !Visible;
	}
    
	public override void _Process(double delta)
	{
		Rotation += _angularSpeed * (float)delta;
		var velocity = Vector2.Up.Rotated(Rotation) * _speed;
		Position += velocity * (float)delta;
	}

}
