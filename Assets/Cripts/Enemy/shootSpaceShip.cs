using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootSpaceShip : Point
{
    GameObject player;
    Rigidbody rb;
    float speedV;
    float time;
    int count = 0;

    [SerializeField]
    private GameObject boom;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(0.5f, 2);
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        speedV = 10f;


        if (player)
        {
            Vector3 direction = player.transform.localPosition - transform.localPosition;
            Vector3 velocity = direction.normalized * speedV;
            rb.velocity = velocity;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!(collision.gameObject.CompareTag("spaceship") && (collision.gameObject.CompareTag("block"))))
        {
            Instantiate(boom, gameObject.transform.localPosition, transform.rotation);

            if (collision.gameObject.CompareTag("Player"))
            {


            }
            else
            {
                Destroy(collision.gameObject);

                if (collision.gameObject.CompareTag("ban"))
                {
                    if (count <= 2)
                    {
                        count++;
                    }
                    else
                    {
                        Destroy(gameObject);
                    }
                }
                if (collision.gameObject.CompareTag("ban3"))
                {

                    Destroy(gameObject);

                }
            }


        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "spaceship" && other.tag != "block")
        {
            Instantiate(boom, gameObject.transform.localPosition, transform.rotation);
            if (other.tag == "Player")
            {
                
            }
            else
            {
                Destroy(other.gameObject);

                if (other.tag == "ban")
                {
                    if (count <= 2)
                    {
                        count++;
                    }
                    else
                    {
                        Destroy(gameObject);
                    }
                }
                if (other.tag == "ban3")
                {
                    Destroy(gameObject);
                }

            }


        }
    }


    // Update is called once per frame

}
