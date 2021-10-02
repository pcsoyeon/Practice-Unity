using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCtrl : MonoBehaviour
{
    public float rotSpeed = 100;

    Vector3 AXIS_X = new Vector3(1, 0, 0);

    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        // x축 회전 
        float my = Input.GetAxis("Mouse Y");

        Vector3 rotX = AXIS_X * my * rotSpeed * Time.deltaTime;

        tr.Rotate(rotX, Space.Self);
    }
}
