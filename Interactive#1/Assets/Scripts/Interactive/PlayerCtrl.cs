﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    float h = 0.0f;
    float v = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        print("h= " + h);
        print("v= " + v);
    }
}
