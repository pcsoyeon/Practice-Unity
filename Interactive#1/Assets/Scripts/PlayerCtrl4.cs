﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl4 : MonoBehaviour
{
    private Transform tr;
    public float rotSpeed = 100.0f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        tr.Rotate(0, mx * rotSpeed, 0, Space.World);
        tr.Rotate(mx * rotSpeed, 0, 0, Space.World);
    }
}
