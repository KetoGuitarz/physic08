using System;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shooter;
    public float shootForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shooter.position, transform.rotation);

        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(shooter.right * shootForce, ForceMode.Impulse);
    }
}

