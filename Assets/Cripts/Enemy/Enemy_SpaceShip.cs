using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_SpaceShip : Enemys
{


    Rigidbody rb;
    [SerializeField]
    private GameObject tallet;
    private GameObject tempTallet;
    [SerializeField]
    private GameObject boom;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {


        rb = GetComponent<Rigidbody>();


        rb.velocity = Vector3.forward * -3f;


        StartCoroutine(shoot());
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(tempTallet == null);
        if (player && transform.localPosition.z <= -4f)
        {
            transform.LookAt(player.transform);
            rb.velocity = Vector3.zero;

        }
    }

    IEnumerator shoot()
    {

        yield return new WaitForSeconds(Random.Range(3.0f, 5.0f));

        if (transform.localPosition.z < -4)
        {

            tempTallet = tallet;
            Vector3 t = transform.localPosition;
            Instantiate(tempTallet, t, transform.rotation);
        }

        StartCoroutine(shoot());
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("spaceship") && !collision.gameObject.CompareTag("block") && !collision.gameObject.CompareTag("shootSpaceship"))
        {
            Destroy(collision.gameObject);
            Instantiate(boom, gameObject.transform.localPosition, transform.rotation);

            if (count <= 9)
            {
                if (collision.gameObject.CompareTag("ban"))
                {
                    count++;
                }
                else if (collision.gameObject.CompareTag("ban"))
                {
                    count += 2;
                }
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "spaceship" && other.tag != "block" && other.tag != "shootSpaceship")
        {
            Destroy(other.gameObject);
            Instantiate(boom, gameObject.transform.localPosition, transform.rotation);

            if (count <= 9)
            {
                if (other.tag == "ban")
                {
                    count++;
                }
                else if (other.tag == "ban3")
                {
                    count += 2;
                }
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }


}
