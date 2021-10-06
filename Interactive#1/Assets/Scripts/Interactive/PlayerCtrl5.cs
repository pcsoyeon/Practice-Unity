using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl5 : MonoBehaviour
{
    public float force = 300;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // 위로 힘을 가함 -> 점프 
            rb.AddForce(0, force, 0);
        }
    }
}
