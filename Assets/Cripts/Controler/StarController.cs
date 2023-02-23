using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    [SerializeField]
    private GameObject star1, star2, star3;





    //public Text reStart, endGame;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(CreateStars());
    }


    IEnumerator CreateStars()
    {

        yield return new WaitForSeconds(Random.Range(1f, 3f));

        int i = Random.Range(0, 101);
        Vector3 t;
        t.z = 2;
        t.x = Random.Range(-14, 14);
        t.y = 30;

        if (i < 50)
        {
            Instantiate(star1, t, transform.rotation);
        }
        else if (i < 80)
        {
            Instantiate(star2, t, transform.rotation);
        }
        else
        {
            Instantiate(star3, t, transform.rotation);
        }

        StartCoroutine(CreateStars());

    }


}
