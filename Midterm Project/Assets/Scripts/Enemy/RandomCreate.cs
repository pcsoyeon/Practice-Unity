using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreate : MonoBehaviour
{
    int initEnemy1s;
    int enemy1s;

    int initEnemy2s;
    int enemy2s;

    public GameObject enemy1;
    public GameObject enemy2;

    void Start()
    {
        initEnemy1s = (int)GameObject.FindGameObjectsWithTag("ENEMY").Length;
        enemy1s = initEnemy1s;

        initEnemy2s = (int)GameObject.FindGameObjectsWithTag("ENEMY2").Length;
        enemy2s = initEnemy2s;
    }

    
    void Update()
    {
        initEnemy1s = (int)GameObject.FindGameObjectsWithTag("ENEMY").Length;
        initEnemy2s = (int)GameObject.FindGameObjectsWithTag("ENEMY2").Length;

        if (enemy1s != initEnemy1s)
        {
            GameObject obj = Instantiate(enemy1);
            obj.GetComponent<Transform>().position = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));
        }

        if (enemy2s != initEnemy2s)
        {
            GameObject obj = Instantiate(enemy2);
            obj.GetComponent<Transform>().position = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));

            obj = Instantiate(enemy2);
            obj.GetComponent<Transform>().position = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));

            initEnemy2s++;
        }
    }
}
