using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpaceShip : MonoBehaviour
{
    [SerializeField]
    private GameObject boom;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shootSpaceship"))
        {
            Instantiate(boom, gameObject.transform.localPosition, transform.rotation);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "shootSpaceship")
        {
            Instantiate(boom, gameObject.transform.localPosition, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update


}
