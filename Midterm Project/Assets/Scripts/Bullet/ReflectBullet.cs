using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "BULLET2")
        {

        }
    }
}
