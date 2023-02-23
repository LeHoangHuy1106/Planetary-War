using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBoom : MonoBehaviour
{

    [SerializeField]
    private GameObject boom;



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "enemy")
        {

            Instantiate(boom, other.gameObject.transform.localPosition, transform.rotation);
            Destroy(other.gameObject,0.1f);
        }
    }
 
}
