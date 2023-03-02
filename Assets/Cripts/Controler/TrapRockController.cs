using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrapRockController : MonoBehaviour
{
    [SerializeField]
    private GameObject rock1, rock2, rock3;
    int scale;
    private int level;
    private float start, end;





    //public Text reStart, endGame;
    // Start is called before the first frame update
    void Start()
    {

        level = PlayerPrefs.GetInt("level", 0);

        Debug.Log("Level is choosed:" + level);

        if (level == 0)
        {
            start = 3.0f;
            end = 6.0f;
        }
        else if (level == 1)
        {
            start = 2.0f;
            end = 4.0f;
        }
        else if (level == 2)
        {
            start = 1.0f;
            end = 3.0f;
        }

        StartCoroutine(CreatePlanes());
    }


    IEnumerator CreatePlanes()
    {

        yield return new WaitForSeconds(Random.Range(start, end));

        int i = Random.Range(0, 3);
        Vector3 t;
        t.z = 2;
        t.x = Random.Range(-14, 14);
        t.y = 30;

        // create vector scale
        scale = Random.RandomRange(1, 4);

        


        switch (i)
        {
            
            case 0:
                Debug.Log("R 1");
                rock1.transform.localScale = transform.localScale * scale;
                Instantiate(rock1, t, transform.rotation);

                break;
            case 1:
                Debug.Log("R 2");
                rock2.transform.localScale = transform.localScale * scale;
                Instantiate(rock2, t, transform.rotation);

                break;
            case 2:
                Debug.Log("R 3");
                rock3.transform.localScale = transform.localScale * scale;
                Instantiate(rock3, t, transform.rotation);

                break;
        }


        StartCoroutine(CreatePlanes());

    }


}
