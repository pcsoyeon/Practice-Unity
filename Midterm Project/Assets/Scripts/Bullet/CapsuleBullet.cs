using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBullet : MonoBehaviour
{
    public float speed = 5.0f;
    Transform tr;
    public Vector3 lookDir;

    void Start()
    {
        tr = GetComponent<Transform>();
        Destroy(gameObject, 5.0f);
    }

    void Update()
    {
        //tr.Translate(lookDir * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("TANK"))
        {
            Destroy(gameObject);
        }
    }
}
