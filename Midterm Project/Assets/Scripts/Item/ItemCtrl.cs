using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : MonoBehaviour
{
    public float rotSpeed = 100.0f;
    public PlayerHealthMng phm;

    void Start()
    {
        
    }
    
    void Update()
    {
        float speed = rotSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * speed, Space.World);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("TANK"))
        {
            Destroy(this.gameObject);
        }
    }
}
