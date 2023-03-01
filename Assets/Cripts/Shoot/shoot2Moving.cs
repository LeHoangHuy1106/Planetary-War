using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2Moving : Point
{
    Rigidbody rb;
    float speed = 20f;
    // count enemy dead
    int count;
    [SerializeField]
    private GameObject boom;

    AudioSource audio_;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        rb.velocity = (Vector3.forward * speed);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (count <= 2)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {

                Instantiate(boom, transform.localPosition, transform.rotation);

                Destroy(collision.gameObject);
                pointController.SetPoint(1);
                count++;
            }

            else if(collision.gameObject.CompareTag("spaceship"))
            {
                pointController.SetPoint(1);
                count++;
            }
        }

        else

        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (count <= 3)
        {
            if (other.tag == "enemy")
            {

                pointController.SetPoint(1);
                Destroy(other.gameObject);
                Instantiate(boom, transform.localPosition, transform.rotation);
            }
            else if (other.tag == "pointBlue")
            {
                Destroy(other.gameObject);
                Instantiate(boom, transform.localPosition, transform.rotation);

            }
            else if (other.tag == "pointYellow")
            {
                Debug.Log("VaCham");
                Destroy(other.gameObject);
                Instantiate(boom, transform.localPosition, transform.rotation);

            }
            else if (other.tag == "pointRed")
            {
                Destroy(other.gameObject);
                Instantiate(boom, transform.localPosition, transform.rotation);

            }
            else if (other.tag == "spaceship")
            {
                pointController.SetPoint(1);
                Instantiate(boom, transform.localPosition, transform.rotation);
            }
            count++;

        }
        else

        {
            Destroy(gameObject);
        }

    }
}
