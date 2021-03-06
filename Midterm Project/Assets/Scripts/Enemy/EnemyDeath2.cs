using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath2 : MonoBehaviour
{
    public int deathNum = 3;

    public EnemyHealthMng ehm;
    public EnemyKillMng ekm;

    int hitCount = 0;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            ehm.SubtractHealth(1);

            if (++hitCount == deathNum)
            {
                GetComponent<EnemyCtrl2>().enabled = false;
                ekm.AddScore(1);
            }
        }
    }
}
