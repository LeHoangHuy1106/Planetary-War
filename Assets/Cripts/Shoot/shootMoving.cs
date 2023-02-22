using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootMoving : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10f;
    public GameObject boom;
    
    public AudioClip clip1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        


    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=(Vector3.forward * speed);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            
            Instantiate(boom, transform.localPosition, transform.rotation);
            GameObject.Find("Audio").GetComponent<AudioSource>().clip = clip1;
            GameObject.Find("Audio").GetComponent<AudioSource>().Play();
            GameObject.Find("GameController").GetComponent<Controll>().count += 1;
            Destroy(gameObject);
            Destroy(collision.gameObject);

            
          
           
         }
    }
}
