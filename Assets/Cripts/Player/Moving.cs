using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    private float speed = 100f;

    [SerializeField]
    private GameObject boom;

    [SerializeField]
    private GameObject soundController;

    [SerializeField]
    private AudioClip clip;

    private AudioSource audio;

    [SerializeField]
    private PointController pointController;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = soundController.GetComponent<AudioSource>();
        anim = GetComponent<Animator>();




    }

    // Update is called once per frame
    void Update()
    {
        changeAnimation();
        moving();
        limit();

    }

    void changeAnimation()
    {
        anim.SetBool("isWounded", true);
        anim.SetBool("isWounded", false);
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
        T.x = Mathf.Clamp(T.x, -14.0f, 14.0f);
        T.z = Mathf.Clamp(T.z, -17f, -3f);
        transform.localPosition = T;

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("spaceship"))
        {
          
            pointController.SetHP(-1);
            if (pointController.GetHP() <= 0)
            {
                Destroy(gameObject);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "enemy")
        {
            Instantiate(boom, transform.localPosition, transform.rotation);
            Destroy(other.gameObject);
            pointController.SetHP(-1);
            changeAnimation();
            if (pointController.GetHP() <= 0)
            {
                Destroy(gameObject);
            }

        }
        else if (other.tag == "pointBlue")
        {
            Destroy(other.gameObject);
            audio.clip = clip;

            audio.Play();
            pointController.SetPointBlue(3);
        }
        else if (other.tag == "pointYellow")
        {
            Destroy(other.gameObject);
            audio.clip = clip;
            audio.Play();
            pointController.SetPointYellow(1);
        }
        else if (other.tag == "pointRed")
        {
            Destroy(other.gameObject);
            audio.clip = clip;
            audio.Play();
            pointController.SetPointRed(5);
        }
        else if (other.tag == "HP")
        {
            Destroy(other.gameObject);
            audio.clip = clip;
            audio.Play();
            pointController.SetHP(1);
        }
        else if (other.tag == "spaceship")
        {
            
           
            pointController.SetHP(-1);
            changeAnimation();
            if (pointController.GetHP() <= 0)
            {
                Destroy(gameObject);
               
            }
            
          
        }
    }



}
