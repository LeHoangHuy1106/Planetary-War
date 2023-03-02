using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Rotate : MonoBehaviour
{
    float  y ,speed;
    Rigidbody rb;
    new Vector3 temp;


    [SerializeField]
    private GameObject boom;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 2);
 
        y = Random.Range(100, 180);
  

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        temp = new Vector3(0, y, 0) * Time.deltaTime * speed;
        transform.Rotate(temp) ;
        Debug.Log(temp);
        //
        float scaleFactor = Mathf.Lerp(0.0f, 0.5f, Time.time / 5f);
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);

        rb.velocity = (Vector3.forward * 2f);

    }


}
