using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float speed = 1000.0f; // 총알 발사 속도

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // 오브젝트의 y축 방향으로 힘을 가함 
        rb.AddForce(transform.up * speed);
    }

    void Update()
    {
        
    }
}
