using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{

    public int lives = 3;
    public Animator healthbar;
    public Animator gameover;
    public Animator end;
    public PlayerMovment player;
    void Start()
    { 
        lives = 3;
    }

  
    public void HeartLoss()
    {
        if(lives > 0)
            lives--;
        if(healthbar!= null)  
            healthbar.SetInteger("lives", lives);
        if(lives == 0){
            gameover.SetInteger("lives", 0);
            end.SetInteger("lives", 0);
            player.gameover = true;
        }
    }
}
