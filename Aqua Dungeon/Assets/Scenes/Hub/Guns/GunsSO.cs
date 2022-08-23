using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun" , menuName = "Gun")]
public class GunsSO : ScriptableObject
{
    public new string name;

    [Header("Bullets")]
    public GameObject BulletKind;
    public GameObject HitEffect;
    public float BulletAmmount;
    public float BulletSpeed;

    [Header("Gun")]
    public float Knockback;
    public float Weight;

    [Header("CoolDown")]
    public float CooldownBetweenBullets;
    public float GunCooldown;

    [Header("Booleans")]
    public bool isShooting;
    public bool IsReloading;
    



}
