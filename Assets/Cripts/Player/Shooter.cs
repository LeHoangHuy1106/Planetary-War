using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ban;
    GameObject Player;
    float time = 0.2f;
    float limit;
    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= limit) 
        {
            shoot();
            Debug.Log("co");
            limit = Time.time + time;
        }    
        
    }

    void shoot()
    {
        Instantiate(ban, Player.transform.position, ban.transform.rotation);
    }

}
