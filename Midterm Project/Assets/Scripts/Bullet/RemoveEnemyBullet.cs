using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEnemyBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "BULLET2")
        {
            Destroy(collision.gameObject);
        }
    }
}