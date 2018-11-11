using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEController : MonoBehaviour {

    

    public BulletEController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;


    // Update is called once per frame
    void Update()
    {
        
        
         shotCounter -= Time.deltaTime;
         if (shotCounter <= 0)
         {
             shotCounter = timeBetweenShots;
             BulletEController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletEController;
             newBullet.speed = bulletSpeed;     
         }
        
        else
        {
            shotCounter = 0;
        }
    }
}
