using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial2 : MonoBehaviour
{
    Transform tr;

    public float moveSpeed = 0.1f;
    public float rotSpeed = 100.0f;

    float h = 0.0f;
    float v = 0.0f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        float mx = Input.GetAxis("Mouse X");

        tr.Translate(h * moveSpeed, 0, v * moveSpeed);
        tr.Rotate(0, mx * rotSpeed, 0, Space.World);
    }
}
