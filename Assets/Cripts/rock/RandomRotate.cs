using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    float x, y, z, speed;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {

        speed = Random.Range(1,2);
        x = Random.Range(0, 180);
        y = Random.Range(0, 180);
        z = Random.Range(0, 180);
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime * speed);

    }
    
}
