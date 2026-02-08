using UnityEngine;

public class ShootRayCast : MonoBehaviour
{
    [SerializeField] Transform shootpoint;
    [SerializeField] GameObject shootpointprefab;
    [SerializeField] GameObject hitpointprefab;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

        Shoot();



        void Shoot()
        {
            Debug.DrawRay(shootpoint.position, transform.forward * 30.0f, Color.magenta);
            RaycastHit hit;

            if (Physics.Raycast(shootpoint.position, transform.forward, out hit, 100f))
            {

                Debug.DrawRay(shootpoint.position, transform.forward * hit.distance, Color.salmon);
                Debug.Log("Ray hits " + hit.collider.name);


            }

            if (Input.GetMouseButtonDown(0))
            {

                Instantiate(shootpointprefab, shootpoint.position, Quaternion.identity);

                Instantiate(hitpointprefab, hit.point, Quaternion.identity);

                
            }






        }

    }
}
