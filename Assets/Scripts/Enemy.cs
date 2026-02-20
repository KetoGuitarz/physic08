using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] int HP = 50;
    [SerializeField] int Damage = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public void TakeDamage()
    {

        HP -= Damage;
        Debug.Log($"{name} took {Damage} damage");

        if (HP <= 0)
            Destroy(this.gameObject, 1f);


    }





    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

