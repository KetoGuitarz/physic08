using UnityEngine;

public class Friction : MonoBehaviour
{
    public float Dynamicfiction;
    public float Staticfiction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Collider col = GetComponent<Collider>();
       col.material.dynamicFriction = Dynamicfiction;
       col.material.staticFriction = Staticfiction;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
