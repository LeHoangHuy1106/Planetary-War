using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_rotation : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    float speedV;
    // Start is called before the first frame update
    void Start()
       
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        speedV = 5.0f;
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
