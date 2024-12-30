using Godot;

public partial class MyNode2D : Node2D
{
    [Signal]
    public delegate void HealthDepletedEventHandler();

    private int _health = 10;
}