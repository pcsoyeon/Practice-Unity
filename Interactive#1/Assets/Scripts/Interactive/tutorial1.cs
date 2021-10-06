using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial1 : MonoBehaviour
{
    Transform tr;

    public float moveSpeed = 10.0f;
    public float rotSpeed = 100.0f;

    float v = 0.0f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        v = Input.GetAxis("Vertical");
        float tz = v * moveSpeed * Time.deltaTime;
        tr.Translate(0, 0, tz);

        float mx = Input.GetAxis("Horizontal");
        tr.Rotate(0, mx * rotSpeed, 0, Space.World);
    }
}
