using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class autoshooter : MonoBehaviour
{
    public GameObject[] projectiles;
    public Transform firePoint;
    public float shootInterval = 1f;
    public float shootForce = 15f;

    void Start()
    {
        InvokeRepeating("ShootRandom", 0f, shootInterval);
    }

    void ShootRandom()
    {
        if (projectiles.Length == 0) return;

        
        GameObject randomProjectile = projectiles[Random.Range(0, projectiles.Length)];

        GameObject bullet = Instantiate(randomProjectile, firePoint.position, Random.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * shootForce, ForceMode.Impulse);
        }
    }
}