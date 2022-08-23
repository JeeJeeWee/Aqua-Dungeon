using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GunsSO Gun;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(Gun.BulletKind, firePoint.position, firePoint.rotation);
        Rigidbody2D rbbullet = bullet.GetComponent<Rigidbody2D>();
        rbbullet.AddForce(firePoint.right * Gun.BulletSpeed, ForceMode2D.Impulse);
    }
}
