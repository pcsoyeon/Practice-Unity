using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePos : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    public float shortInterval = 1;
    float shotTime = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            shotTime += Time.deltaTime;

            if (shotTime > shortInterval)
            {
                GameObject obj = Instantiate(bullet, firePos.position, firePos.rotation);
                Destroy(obj, 3.0f);

                shotTime = 0;
            }
            
        }
    }
}
