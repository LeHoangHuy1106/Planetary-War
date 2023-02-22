using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBackgound : MonoBehaviour
{
    Vector3 pos;
    Rigidbody rb;
    bool check_clone = false;
    public GameObject backGround;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
      pos = transform.localPosition;
        
        if ( pos.z >= -80)
        {
            rb.velocity = Vector3.forward *-1 * speed ;
   
            if (check_clone == false && pos.z <= 10)
            {
                Vector3 t = pos;
                t.z = 60;
                Instantiate(backGround, t, transform.rotation);
                check_clone = true;
            }


        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
