using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2Moving : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10f;

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
        if (count <=2)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {

                Instantiate(boom, transform.localPosition, transform.rotation);

                Destroy(collision.gameObject);
                count++;
            }
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }    
    }
    public void OnTriggerEnter(Collider other)
    {
        if (count <= 2)
        {
            if (other.tag == "enemy")
            {
               
                
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
            count++;
        }
        else
        {
            Instantiate(boom, transform.localPosition, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
