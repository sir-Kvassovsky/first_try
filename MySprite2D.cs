using Godot;
using System;
using static MyNode2D;

public partial class MySprite2D : Sprite2D
{
	private int _speed = 400;
	private int _health = 100;
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
	
	public void TakeDamage(int amount)
	{
		int oldHealth = _health;
		_health -= amount;
		EmitSignal(nameof(MyNode2D), oldHealth, _health);
	}

    public override void _Process(double delta)
	{
		Rotation += _angularSpeed * (float)delta;
		var velocity = Vector2.Up.Rotated(Rotation) * _speed;
		Position += velocity * (float)delta;
	}

}
