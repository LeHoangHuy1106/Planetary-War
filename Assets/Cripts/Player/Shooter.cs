using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet1, bullet2, bullet3;

    float time = 0.2f;
    float limit;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= limit) 
        {
            shoot();

            limit = Time.time + time;
        }    
        
    }

    void shoot()
    {
        rb.AddForce(new Vector3(0, 0, -2000f));
        Instantiate(bullet1, transform.position, bullet1.transform.rotation);


    }

}
