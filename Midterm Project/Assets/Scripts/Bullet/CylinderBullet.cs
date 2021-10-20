using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderBullet : MonoBehaviour
{
    public float speed = 5.0f;
    Transform tr;
    public Vector3 lookDir;

    void Start()
    {
        tr = GetComponent<Transform>();
        Destroy(gameObject, 10.0f);
    }

    void Update()
    {
        tr.Translate(lookDir * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WALL"))
        {
            speed -= 1.0f;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("TANK"))
        {
            Destroy(gameObject);
        }
    }
}
