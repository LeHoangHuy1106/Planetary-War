using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1, enemy2, enemy3, player;





    //public Text reStart, endGame;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(CreatePlanes());
    }


    IEnumerator CreatePlanes()
    {

        yield return new WaitForSeconds(Random.Range(2f, 5f));

        int i = Random.Range(0, 101);
        Vector3 t;
        t.z = 2;
        t.x = Random.Range(-14, 14);
        t.y = 30;
        GameObject enemy;
        if ( i <60)
        {
            enemy= Instantiate(enemy1, t, transform.rotation);
            
        }
        else if (i<90)
        {
            enemy= Instantiate(enemy2, t, transform.rotation);
        }
        else
        {
            enemy = Instantiate(enemy3, t, enemy3.transform.rotation);
            
        }
        enemy.GetComponent<Enemys>().SetPlayer(player);

        StartCoroutine(CreatePlanes());

    }
}
