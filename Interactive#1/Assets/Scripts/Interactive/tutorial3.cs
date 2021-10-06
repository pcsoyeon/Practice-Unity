using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial3 : MonoBehaviour
{
    private Transform tr;

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
        h = Input.GetAxis("Mouse X");
        v = Input.GetAxis("Mouse Y");
        float msw = Input.GetAxis("Mouse ScrollWheel");

        tr.Translate(h * moveSpeed, 0, v * moveSpeed);
        tr.Rotate(0, msw * rotSpeed, 0, Space.World);
    }
}
