using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
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
                ekm.AddScore(1);
            }
        }
    }
}
