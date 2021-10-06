using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet2 : MonoBehaviour
{
    public GameObject sparkEffect;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "BULLET")
        {
            GameObject spark = Instantiate(sparkEffect);
            spark.transform.position = collision.transform.position;
            Destroy(spark, 1); // effect 제거 (메모리에 쌓이므로)

            Destroy(collision.gameObject);
        }
    }
}
