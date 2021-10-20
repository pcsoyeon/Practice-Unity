using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotSpeed = 10f;
    public float force = 300;

    public int death = 0;
    private int hp = 10;

    public GameObject gameOver;
    public PlayerHealthMng phm;

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
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        tr.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * h * rotSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("ENHANCE"))
        {
            GetComponentInChildren<FirePos>().shortInterval -= 0.2f;
        }

        if (coll.collider.CompareTag("RECOVER"))
        {
            phm.AddHealth(1);
            ++hp;
        }

        if (coll.collider.CompareTag("BULLET2"))
        {
            phm.SubtractHealth(1);
            --hp;
            if (hp <= death)
            {
                this.enabled = false;
            }
        }

    }

    void OnDisable()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().AddForce(0, 5000, 0);
    }
}


