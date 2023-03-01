using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootMoving : Point
{
    Rigidbody rb;
    float speed = 10f;


    [SerializeField]
    private GameObject boom;



    AudioSource audio_;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = (Vector3.forward * speed);
     
    }



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            pointController.SetPoint(1);
            Instantiate(boom, transform.localPosition, transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Instantiate(boom, transform.localPosition, transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
            pointController.SetPoint(1);


        }
        if (other.tag == "spaceship")
        {
            pointController.SetPoint(1);
        }

        else if (other.tag == "pointBlue")
        {
            Destroy(other.gameObject);
            Instantiate(boom, transform.localPosition, transform.rotation);
            
        }
        else if (other.tag == "pointYellow")
        {
            Destroy(other.gameObject);
            Instantiate(boom, transform.localPosition, transform.rotation);

        }
        else if (other.tag == "pointRed")
        {
            Destroy(other.gameObject);
            Instantiate(boom, transform.localPosition, transform.rotation);

        }
    }
}
