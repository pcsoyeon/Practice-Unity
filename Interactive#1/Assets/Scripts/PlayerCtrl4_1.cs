using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl4_1 : MonoBehaviour
{
    private Transform tr;
    public float rotSpeed = 100.0f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        float msw = Input.GetAxis("Mouse ScrollWheel");

        tr.Rotate(msw * rotSpeed, 0, 0, Space.World);
    }
}
