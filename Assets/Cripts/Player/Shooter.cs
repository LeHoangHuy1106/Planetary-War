using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet1, bullet2, bullet3;

    float time = 0.2f;
    float limit;

    int i;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            i = (i+=1)%3;
        }
        if (Input.GetMouseButtonDown(0) && Time.time >= limit)
        {

            shoot();
            limit = Time.time + time;
        }


        Debug.Log(i);
    }

    void shoot()
    {
        
        switch ((i % 3))
        {
            case 1:
                {
                    rb.AddForce(new Vector3(0, 0, -2000f));
                    Instantiate(bullet1, transform.position, bullet1.transform.rotation);
                    break;
                }
            case 2:
                {
                    rb.AddForce(new Vector3(0, 0, -2000f));
                    Instantiate(bullet2, transform.position, bullet1.transform.rotation);
                    break;
                }
            case 0:
                {
                    rb.AddForce(new Vector3(0, 0, -2000f));
                    Instantiate(bullet3, transform.position, bullet1.transform.rotation);
                    break;
                }

        }



    }

}
