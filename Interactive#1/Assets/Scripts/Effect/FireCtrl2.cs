using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl2 : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    ParticleSystem muzzleFlash;

    void Start()
    {
        // 하위 오브젝트의 이펙트 컴포넌트 가져오기 
        muzzleFlash = firePos.GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        // 마우스 좌측 버튼 클릭
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject obj = Instantiate(bullet, firePos.position, firePos.rotation);
        Destroy(obj, 3);

        muzzleFlash.Play(); // 사격 이펙트 실행 
    }
}
