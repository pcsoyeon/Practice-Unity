using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : MonoBehaviour
{
    public float rotSpeed = 100.0f;

    void Start()
    {
        
    }
    
    void Update()
    {
        float speed = rotSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * speed);
    }
}
