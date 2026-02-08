using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * 20f, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 20f))
        {
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.green);
            Debug.Log("Ray hits " + hit.collider.name);
        }

        if (hit.collider.CompareTag("Star"))
        {
            Renderer renderer = hit.collider.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.green;
            }

            Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.useGravity = true;
            }
        }
    }
}
