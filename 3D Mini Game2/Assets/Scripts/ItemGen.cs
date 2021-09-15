using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGen : MonoBehaviour
{
    public GameObject apple;
    public GameObject bomb;

    float curTime = 0;

    void Update()
    {
        curTime += Time.deltaTime;

        if (curTime > 1.5f)
        {
            // 오브젝트 생성
            GameObject obj = (Random.Range(0, 10) > 2) ? Instantiate(apple) : Instantiate(bomb);

            // 랜덤 위치 지정
            // 범위에서 2는 포함 x 
            Vector3 objPos = new Vector3(Random.Range(-1, 2), 4, Random.Range(-1, 2));

            obj.transform.position = objPos;

            Destroy(obj, 5); // 5초 후 제거
            curTime = 0; // 시간 초기화 -> 1.5초마다 아이템 생성
        }
    }
}
