using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public int deathNum = 10;
    public PlayerHealthMng hm;

    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ENEMY"))
        {
            hm.SubtractHealth(1);
        }

        if (collision.collider.CompareTag("BULLET2"))
        {
            hm.SubtractHealth(1);
        }
    }
}
