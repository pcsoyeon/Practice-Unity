﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCtrl : MonoBehaviour
{
    int hitCount = 0; // 발사체에 맞은 횟수 
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BULLET"))
        {
            if (++hitCount == 3) // 발사체에 3회 맞았다면 
            {
                rb.AddForce(0, 10000, 0); // 위로 힘을 가함 
            }
        }
    }
}
