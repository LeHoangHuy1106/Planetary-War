using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controll : MonoBehaviour
{
    public GameObject rock1, rock2, rock3, enemy;
    public int count=0;
    public Text core;
    //public Text reStart, endGame;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("EndGame").GetComponent<Text>().text= "";
        GameObject.Find("Restart").GetComponent<Text>().text = "press S to play game!!";
        Time.timeScale = 0;

        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && Time.timeScale == 0)
        {
            GameObject.Find("Restart").GetComponent<Text>().text = "";
            Time.timeScale = 1;
        }
            
        Core();
        playAgain();
       
    }

    void Core()
    {
        core.text = "CORE: " + count;
    }
    void playAgain()
    {
        if(!GameObject.Find("Player"))
        {
            Debug.Log("cochet");
            //    GameObject.Find("EndGame").active = true;
            //    GameObject.Find("Restart").active = true;
            GameObject.Find("EndGame").GetComponent<Text>().text = "GAME OVER";
            GameObject.Find("Restart").GetComponent<Text>().text = "press S to play again!";
            if (Input.GetKey(KeyCode.S))
            {
                Application.LoadLevel("SampleScene");
            }
        }    
    }
        IEnumerator SpawnWaves()   
    {

        yield return new WaitForSeconds(Random.Range(1f, 3f));
        int i = Random.Range(0, 4);

        if (i==0)
        {
            Vector3 t;
            t.z = 20;
            t.x = Random.Range(-5, 5);
            t.y = -1;
            Instantiate(rock1,t, transform.rotation);
        }
        else if (i == 1)
        {
            Vector3 t;
            t.z = 20;
            t.x = Random.Range(-5, 5);
            t.y = -1;
            Instantiate(rock2, t, transform.rotation);
        }
        else if (i == 2)
        {
            Vector3 t;
            t.z = 20;
            t.x = Random.Range(-5, 5);
            t.y = -1;
            Instantiate(rock3, t, transform.rotation);
        }
        else
        {
            Vector3 t;
            t.z = 20;
            t.x = Random.Range(-5, 5);
            t.y = -1;
            Instantiate(enemy, t, transform.rotation);
        }    
        StartCoroutine(SpawnWaves());
        
    }    
}
