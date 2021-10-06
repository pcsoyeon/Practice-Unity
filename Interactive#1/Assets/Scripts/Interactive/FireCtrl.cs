using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet; // 총알 프리팹 
    public Transform firePos; // 총알의 발사 좌표 (빈 오브젝트) -> 오브젝트의 하나의 컴포넌트만 갖고 올 수 있음 

    void Update()
    {
        // 마우스 왼쪽 버튼  클릭 
        if (Input.GetMouseButtonDown(0))
        {
            // firePos의 위치 및 방향으로 발사체 생성
            // Instatiate -> 오브젝트를 실시간으로 생성 해주는 것
            // 첫번째 오브젝트를 두번째 위치로 세번째 방향으로 오브젝트 생성 
            GameObject obj = Instantiate(bullet, firePos.position, firePos.rotation);

            Destroy(obj, 3.0f); // 3초 후 자동 소멸 -> 메모리에 남아 있지 않도록 
        }
    }
}
