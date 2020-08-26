using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform t;
    void Start()
    {
        Transform temp = transform;
        temp = t;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
