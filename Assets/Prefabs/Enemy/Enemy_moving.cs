using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_moving : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        limit();
        float t=1;
        if (transform.localPosition.x < -4 && transform.localPosition.x > 4)
        {
            t = t*-1;
        }

  //      rb.velocity = (Vector3.right) * t * 5f ;
    //    rb.velocity = (Vector3.back) * 5f;

        rb.velocity  = new Vector3(0,0 ,-150f*  Time.deltaTime);
    }
    void limit()
    {
        Vector3 T = transform.localPosition;
        T.x = Mathf.Clamp(T.x, -5.0f, 5.0f);

        transform.localPosition = T;

    }
}
