using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet1, bullet2, bullet3;

    [SerializeField]
    private PointController pointController;

    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private AudioClip clip;

    float time = 0.2f;
    float limit;

    int i;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            i = (i += 1) % 3;
            audio.clip = clip;
            audio.Play();
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
        



    }
    void shoot()
    {
        if (Time.time >= limit)
        {
            chooseBullet();
            limit = Time.time + time;
        }
    }



    void chooseBullet()
    {
        GameObject bullet;
        switch ((i % 3))
        {
            case 0:
                {
                    if (pointController.GetPointRed() >= 1)
                    {
                        rb.AddForce(new Vector3(0, 0, -2000f));
                        bullet = Instantiate(bullet1, transform.position, bullet1.transform.rotation);
                        bullet.GetComponent<Point>().SetPointController(pointController);
                        pointController.SetPointRed(-1);
                    }
                    break;


                }
            case 1:
                {
                    if (pointController.GetPointBlue() > 0)
                    {
                        rb.AddForce(new Vector3(0, 0, -2000f));
                        bullet = Instantiate(bullet2, transform.position, bullet2.transform.rotation);
                        bullet.GetComponent<Point>().SetPointController(pointController);
                        pointController.SetPointBlue(-1);
                    }
                    break;
                }
            case 2:
                {
                    if (pointController.GetPointYellow() > 0)
                    {
                        rb.AddForce(new Vector3(0, 0, -2000f));
                        bullet = Instantiate(bullet3, transform.position, bullet3.transform.rotation);
                        bullet.GetComponent<Point>().SetPointController(pointController);
                        pointController.SetPointYellow(-1);
                    }
                    break;
                }

        }




    }

}
