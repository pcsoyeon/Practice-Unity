using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEnemyBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "BULLET2")
        {
            GameObject spark = Instantiate(sparkEffect);

            spark.transform.position = collision.transform.position; // 충돌 효과 생성 
            spark.transform.localScale *= 0.5f; // effect 절반 크기 

            Destroy(spark, 1); // effect 제거 (메모리에 쌓이므로)
            Destroy(collision.gameObject); // 발사체 제거 
        }
    }
}
