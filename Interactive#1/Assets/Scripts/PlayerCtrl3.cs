using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl3 : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    float h = 0.0f;
    float v = 0.0f;

    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        tr.Translate(h * moveSpeed, 0, v * moveSpeed);
    }
}
