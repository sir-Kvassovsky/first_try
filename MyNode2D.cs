using Godot;

public partial class MyNode2D : Node
{
    [Signal]
    public delegate void HealthChangedEventHandler(int oldValue, int newValue);

    private int _health = 10;
}