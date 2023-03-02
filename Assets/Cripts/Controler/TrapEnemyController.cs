using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1, enemy2, enemy3, player;

    private int level;
    private float start, end;




    //public Text reStart, endGame;
    // Start is called before the first frame update
    void Start()
    {
        
        level  = PlayerPrefs.GetInt("level", 0);

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
