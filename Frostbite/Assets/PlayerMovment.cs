using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovment : MonoBehaviour
{
    public CharacterController2D controller2D;

    float horizontalMove;
    public bool gameover;
     bool jump;

     bool crouch;

     float xStart;
     float yStart;
    float zStart;
    public float moveSpeed;
    public Enemy enemy1;
    public Enemy enemy2;
    public Enemy enemy3;
    public GameOver gameOver;
    Transform temp;
    int test = 0;
    Healthbar healthbar;
    void Start()
    {  
        gameover = false;
        temp = transform;
        xStart = transform.position.x;
        yStart = transform.position.y;
        zStart = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if(Input.GetButtonDown("Jump"))
            jump = true;

        if(Input.GetButtonDown("Crouch"))
            crouch = true;
        else if(Input.GetButtonUp("Crouch"))
            crouch = false;
    }
    void FixedUpdate()
    {
        if(!gameover)
            controller2D.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        else{
            controller2D.Move(0, false, false);
            if(test<150)
                test++;
            else{
                gameover = false;
                test = 0;
                gameOver.GameEnd();
            }
        }
        jump = false;
    }
    
    public void ResetPlayer(){
        temp.position = new Vector3(xStart, yStart, zStart);
        enemy1.isFrozen = false;
        enemy1.temp.position = enemy1.start.position;
        enemy2.isFrozen = false;
        enemy2.temp.position = enemy2.start.position;
        enemy3.isFrozen = false;
        enemy3.temp.position = enemy3.start.position;
    } 

}
