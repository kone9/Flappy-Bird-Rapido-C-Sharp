using Godot;
using System;

public class columna1 : KinematicBody
{
    
    private Escena_principañ datosGlobales;
    float posicionAleatoria;

    public override void _Ready()
    {
        datosGlobales = (Escena_principañ)GetTree().GetNodesInGroup("Escena_principañ")[0];
        GD.Randomize();
        Translation = new Vector3(this.Translation.x,
                            (float)GD.RandRange(Convert.ToDouble(5),Convert.ToDouble(10)),
                            this.Translation.z
                            );
    }


    public override void _PhysicsProcess(float delta)
    {  
        if(datosGlobales.gameOver == false)
        {
            MoveAndCollide(new Vector3(0,0,datosGlobales.dificultad));
            ReposicionarColumna();
        }   
    }

    private void ReposicionarColumna()
    {
        if(Translation.z > 20)
        {
            
            Translation = new Vector3(0,
                            (float)GD.RandRange(Convert.ToDouble(5),Convert.ToDouble(10)),
                            -20
                            );
        }
    }


}
