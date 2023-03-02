using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_rotation : Enemys
{
    Rigidbody rb;
    [SerializeField]
    float speedV = 5f;
    // Start is called before the first frame update
    void Start()
       
    {
        
        rb = GetComponent<Rigidbody>();

        if (player !=null)
        {
            StartCoroutine(ChangeVelocity());
        }

    }

    private void Update()
    {
        if (player)
        {
            transform.LookAt(player.transform);
        }
    }


    // Update is called once per frame

    IEnumerator ChangeVelocity()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));


        {
            if (player)
            {
                Vector3 direction = player.transform.localPosition - transform.localPosition;
                Vector3 velocity = direction.normalized * speedV;
                rb.velocity = velocity;
            }
        }
        StartCoroutine(ChangeVelocity());
    }


}
