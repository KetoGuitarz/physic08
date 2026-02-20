using UnityEngine;

public class Enemy2 : MonoBehaviour
{

    Rigidbody rb;




    public void attack()
    {

        rb.AddTorque(Vector3.up * 50);


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody>();




    }

    // Update is called once per frame
    void Update()
    {

    }
}
