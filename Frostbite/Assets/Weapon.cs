using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public PauseMenu pauseMenu;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && pauseMenu.isPaused == false)
            Shoot();
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
