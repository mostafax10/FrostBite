using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{   
    public LevelComplete levelComplete;
    
    void OnTriggerEnter2D(Collider2D hitInfo){
         PlayerMovment player = hitInfo.GetComponent<PlayerMovment>();
         if(player!= null){
             levelComplete.Win();
         }
    }
}
