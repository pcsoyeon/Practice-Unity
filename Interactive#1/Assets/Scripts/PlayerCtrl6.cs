using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl6 : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotSpeed = 100;
    public float force = 300;

    Vector3 AXIS_X = new Vector3(1, 0, 0);
    Vector3 AXIS_Y = new Vector3(0, 1, 0);
    Vector3 AXIS_Z = new Vector3(0, 0, 1);

    Transform tr;
    Rigidbody rb;

    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Rotate();
        Jump();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDir = (AXIS_X * h + AXIS_Z * v).normalized;

        // move, rotate, jump 를 한번에 하므로 Space.World 매개변수 추가 -> 무조건 월드 좌표계로 
        tr.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self);
    }

    void Rotate()
    {
        // y축 회전 
        float mx = Input.GetAxis("Mouse X");

        Vector3 rotY = AXIS_Y * mx * rotSpeed * Time.deltaTime;

        tr.Rotate(rotY, Space.World);
    }

    void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            // 위로 힘을 가함 -> 점프 
            rb.AddForce(0, force, 0);
        }
    }
}



