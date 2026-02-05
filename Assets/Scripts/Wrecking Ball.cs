using UnityEngine;

public class WrexkingBall : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(Vector3.left * force, ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
