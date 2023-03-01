using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBackgound : MonoBehaviour
{

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward *-10f;
    }

    private void Update()
    {
        if ( transform.localPosition.z <=270f)

        {
            transform.localPosition = new Vector3(0, 0, 545f);
        }
    }
}
