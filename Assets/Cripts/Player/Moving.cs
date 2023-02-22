using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Rigidbody rb;
    public float speed =100f;
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
        moving();
        limit();
    }
    void moving()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -4f);
    }

    void limit()
    {
        Vector3 T = transform.localPosition;
        T.x =Mathf.Clamp(T.x, -5.0f, 5.0f);
        T.z = Mathf.Clamp(T.z,2.4f, 9.3f);
        transform.localPosition = T;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Instantiate(boom, transform.localPosition, transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("Audio").GetComponent<AudioSource>().clip = clip1;
            GameObject.Find("Audio").GetComponent<AudioSource>().Play();
        }
    }


}
