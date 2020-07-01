using Godot;
using System;

public class suelo2 : KinematicBody
{
    private Escena_principañ datosGlobales;
    float movimiento = 0;
    Position3D FinalSuelo1;

    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
         datosGlobales = (Escena_principañ)GetTree().GetNodesInGroup("Escena_principañ")[0];
         FinalSuelo1 = GetTree().GetNodesInGroup("FinalSuelo1")[0] as Position3D;
    }


    public override void _PhysicsProcess(float delta)
    {
        //movimiento -= 1;
        if(datosGlobales.gameOver == false)
        {
            //Translation = new Vector3(0,0,(Translation.z -movimiento) * delta);
            //movimiento = 1 * delta;
            //Translation = new Vector3(this.Translation.x,this.Translation.y,movimiento);
            MoveAndCollide(new Vector3(0,0,datosGlobales.dificultad));
            ReposicionarColumna();
        }
        else
        {
            MoveAndCollide(new Vector3(0,0,0));
        }
        
        
        
    }
     private void ReposicionarColumna()
    {
        if(Translation.z > 60)
        {
            Translation = FinalSuelo1.GlobalTransform.origin;
        }
    }
}
