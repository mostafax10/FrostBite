using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{   
    public Healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerMovment player = hitInfo.GetComponent<PlayerMovment>();
        if(player != null){
            healthbar.HeartLoss();
            player.ResetPlayer();
        }
        else{
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if(enemy != null)
                enemy.isFrozen = false;
                enemy.temp.position = enemy.start.position;
        }
    }
}
