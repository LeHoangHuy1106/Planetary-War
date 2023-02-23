using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRock : MonoBehaviour
{
    float x, y, z, speed;
    Rigidbody rb;
    int level;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // create Vector rotate
        speed = Random.Range(1.0f, 3.0f);
        x = Random.Range(0, 180);
        y = Random.Range(0, 180);
        z = Random.Range(0, 180);

        // get size rock
        level = (int)transform.localScale.x;


        // random speed 
        float speedV = Random.Range(100.0f, 500.0f);
        rb.velocity = (Vector3.back) * speedV * Time.deltaTime;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z) * Time.deltaTime * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.CompareTag("ban"))
        {
            
            GameObject clone = gameObject;
            if (level == 2)
            {
                
                clone.transform.localScale = new Vector3(1, 1, 1);
                Instantiate(clone, transform.localPosition, transform.rotation);
            }
            else if (level == 3)
            {
     
                clone.transform.localScale = new Vector3(2, 2, 2);
                Instantiate(clone, transform.localPosition, transform.rotation);
            }
        }



    }


}
