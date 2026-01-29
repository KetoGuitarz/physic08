using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public transform shooter;
    public float shooterForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseBottonDown(0))
        {
            shooter();
        }
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shooter.position, transform.rotation);

        Rigibody rigibody = bullet.GetComponent<Rigibody>();
        rigibody.AddForce(shooter.right * shootForce, ForceMode.Impulse);
    }
}

