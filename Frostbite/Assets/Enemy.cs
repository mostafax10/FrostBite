using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;
    
    public bool isFrozen;

    public Rigidbody2D ridgedBody;
    public float speed = 20f;
    public Transform point_A;
    public Transform point_B;
    public Transform start;
    Vector3 stop;
    public Transform temp;
    int test = 0;
    public Healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        isFrozen = false;
        transform.position = start.position;
        temp = transform;
        ridgedBody.velocity = transform.right * speed; 
    }
    // Update is called once per frame
    void Update()
    {
        //if(isFrozen)
            //temp.position = stop;
   
        animator.SetBool("isFrozen", isFrozen);
        animator.SetInteger("test", 1);
    }
    void FixedUpdate()
    {
        if(isFrozen){
            ridgedBody.velocity = transform.right * 0;
            
        }
        else
        {
            if(point_A.position.x - temp.position.x <= 1
            || temp.position.x - point_B.position.x <= 1)
                transform.Rotate(0,180,0);
                ridgedBody.velocity = transform.right * speed; 
        } 

    }

    public void Freeze(){
        isFrozen = true;
        //stop = new Vector3(temp.position.x, temp.position.y, temp.position.z);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerMovment player = hitInfo.GetComponent<PlayerMovment>();
        if(player != null && !isFrozen){
            healthbar.HeartLoss();
            player.ResetPlayer();
        }
        else{
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if(enemy != null && !isFrozen){
                enemy.isFrozen = false;
                enemy.temp.position = enemy.start.position;
            }
        }
       
    }
}
