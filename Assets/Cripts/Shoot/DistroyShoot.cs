using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyShoot : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="ban" || other.tag == "enemy")
        {
            Destroy(other.gameObject);
            
        }    
    }
}
