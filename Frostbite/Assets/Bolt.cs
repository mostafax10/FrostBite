using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    public Rigidbody2D ridgedBody;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        ridgedBody.velocity = transform.right * speed; 
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null && !enemy.isFrozen){
            enemy.Freeze();
        }
        Destroy(gameObject);
    }

}
