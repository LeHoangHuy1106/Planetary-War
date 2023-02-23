using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talletE1 : MonoBehaviour
{
    [SerializeField]
    private float speedV= 0.2f;
    Rigidbody rb;
    [SerializeField]
    private GameObject boom;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedV= 12.0f;
        // create Vector rotate



        //

        rb.velocity = (Vector3.back) * speedV ;

    }

    // Update is called once per frame

    /*/
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "enemy")
            {
                Instantiate(boom, transform.localPosition, transform.rotation);
                Destroy(gameObject);
                Destroy(other.gameObject);

            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("enemy"))
            {
                Instantiate(boom, transform.localPosition, transform.rotation);
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }    
        }
    /*/

}
