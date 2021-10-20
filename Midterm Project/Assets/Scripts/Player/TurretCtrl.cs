using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCtrl : MonoBehaviour
{
    public float rotSpeed = 10;

    Vector3 AXIS_Y = new Vector3(0, 1, 0);

    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        Vector3 rotY = AXIS_Y * mx * rotSpeed * Time.deltaTime;
        tr.Rotate(rotY, Space.Self);
    }
}
