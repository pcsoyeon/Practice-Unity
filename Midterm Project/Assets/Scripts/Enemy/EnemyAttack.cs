using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform playerTr;
    public GameObject bullet;
    public float shortInterval = 1;
    float shotTime = 0;

    void Update()
    {
        shotTime += Time.deltaTime;

        shortInterval = Random.Range(2, 5);

        if (shotTime > shortInterval)
        {
            Attack();
            shotTime = 0;
        }
    }

    void Attack()
    {
        Vector3 fireDir = (playerTr.position - transform.position).normalized;

        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody>().AddForce(fireDir * 500);

        Destroy(obj, 10);
    }
}
