using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1, enemy2;





    //public Text reStart, endGame;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(CreatePlanes());
    }


    IEnumerator CreatePlanes()
    {

        yield return new WaitForSeconds(Random.Range(2f, 5f));

        int i = Random.Range(0, 3);
        Vector3 t;
        t.z = 2;
        t.x = Random.Range(-14, 14);
        t.y = 30;


        switch (i)
        {
            case 0:
                Instantiate(enemy1, t, transform.rotation);

                break;
            case 1:
                Instantiate(enemy2, t, transform.rotation);

                break;
            case 3:
                Instantiate(enemy1, t, transform.rotation);

                break;
        }


        StartCoroutine(CreatePlanes());

    }
}
