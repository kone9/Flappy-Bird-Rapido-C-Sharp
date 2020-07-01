using Godot;
using System;

public class PivoteCamara : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public override void _Input(InputEvent @event)
    {
        if(@event is InputEventMouseMotion movimientoMouse)
        {
            if(Input.IsActionPressed("click"))
            {
                RotateY(Mathf.Deg2Rad(movimientoMouse.Relative.x * 0.1f) );
            }
        }
    }
}

