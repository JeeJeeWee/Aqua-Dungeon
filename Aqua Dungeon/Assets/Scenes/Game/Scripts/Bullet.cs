using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GunsSO Gun;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(Gun.HitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.17f);
        Destroy(gameObject);
    }
    
}
