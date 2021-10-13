using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform playerTr; // 주인공 위치
    public GameObject bullet; // 총알 프리팹
    public float shortInterval = 1; // 발사시간 간격
    float shotTime = 0;

    void Update()
    {
        shotTime += Time.deltaTime;

        if (shotTime > shortInterval)
        {
            Attack();
            shotTime = 0;
        }
    }

    void Attack()
    {
        // 사격 방향 계산
        // 목표지점 - 시작지점 (순서 지킬 것)
        Vector3 fireDir = (playerTr.position - transform.position).normalized;

        // 총알 프리팹 생성
        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody>().AddForce(fireDir * 500);

        // 5초 후 자동 소멸 
        Destroy(obj, 5);
    }
}
