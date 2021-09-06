using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // 1. MoveToWards: 등속 이동 - 매개변수(현재위치, 목표위치, 속도)로 구성
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        // 2. SmoothDamp: 현재위치, 목표위치, 참조속도, 속도
        // 주의! 마지막 매개변수에 반비례하여 속도 증가
        // ref: 참조 접근 -> 실시간으로 바뀌는 값 적용 가능 
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        // 3. Lerp: (선형보간) 마지막 매개변수에 비례하여 속도 증가 (최대값 1)
        transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        // 4. SLerp: (구면선형보간)
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
