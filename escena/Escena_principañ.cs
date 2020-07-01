using Godot;
using System;

public class Escena_principañ : Spatial
{
    [Export]
    public float dificultad = 0.01f;
    [Export]
    public bool gameOver = false;
    [Export]
    public bool inicioJuego = false;
    [Export]
    Label fps;
    AudioStreamPlayer selectMenuSound;
    AnimationPlayer _animationPlayer;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        fps = GetNode<Label>("fps");
        _animationPlayer=GetNode<AnimationPlayer>("AnimationPlayer");
        selectMenuSound = GetNode<AudioStreamPlayer>("MusicAndVfx/selectMenuSound");
    }

// // //  // Called every frame. 'delta' is the elapsed time since the previous frame.
// //     public override void _Process(float delta)
// //     {
                  
// //     }

    public override void _PhysicsProcess(float delta)
    {
        fps.Text = "fps= " + Engine.GetFramesPerSecond();
    }
    
    
 

    private void _on_ButtonReiniciar_button_down()
    {
        GetTree().ReloadCurrentScene();
    }

    private void _on_ButtonReiniciar_mouse_entered()
    {
        _animationPlayer.Play("agrandarButton");
        selectMenuSound.Play();
    }

    private void _on_ButtonReiniciar_mouse_exited()
    {
        _animationPlayer.PlayBackwards("agrandarButton");
    }

    private void _on_TimerDificultad_timeout()
    {
        if(!gameOver)
        {
            dificultad += 0.01f;
            GD.Print(dificultad);
        }
    }
}

