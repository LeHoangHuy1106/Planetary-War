using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_RandomMoving : MonoBehaviour
{
    Rigidbody rb;
    float speedV;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedV = Random.Range(250.0f, 400.0f);
        
        rb.velocity = Vector3.back * speedV * Time.deltaTime;

    }






}

