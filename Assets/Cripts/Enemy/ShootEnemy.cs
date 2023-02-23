using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{

    [SerializeField]
    private GameObject tallet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shoot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator shoot()
    {

        Vector3 t = transform.localPosition;
       // t.z += 2.0f;

       
        if( transform.localPosition.z < -2)
        {
            Instantiate(tallet, t, Quaternion.identity);
        }
        yield return new WaitForSeconds(Random.Range(0.5f, 2.0f));
        StartCoroutine(shoot());
    }    
}
