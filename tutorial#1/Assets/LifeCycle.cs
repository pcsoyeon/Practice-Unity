using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Game Object Flow

    // 초기화
    // 1. Awake() -> 게임 오브젝트 실행 시 최초, 한번 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비 되었습니다.");
    }

    // <활성화>
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    // 2. Start() -> 업데이트 전 최초, 한번 실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
   
    // 물리 연산
    // 3. FixedUpdate() -> 물리 연산을 하기 전에 실행 (Update는 주기적으로 호출)
    void FixedUpdate() // FixedUpdate는 1초에 50번 정도 호출
    {
        // cpu 과부하가 발생할 수 있으므로 주로 물리 연산과 관련된 기능만 넣는다.
        //Debug.Log("이동~");
    }

    // 게임 로직
    // 4. Update() -> 물리 연산과 다르게 게임과 관련되어서 주기적으로 업데이트가 필요한 기능 (Fixed와 다르게 사양에 따라 다르게 작동할 수 있음)
    void Update()
    {
        //Debug.Log("몬스터 사냥");
    }

    // 5. 모든 업데이트가 끝난 후 (마지막으로 호출되는 함수)
    void LateUpdate()
    {
        // 캐릭터를 따라가는 카메라, 로직 후처리 등이 많이 쓰임
        //Debug.Log("경험치 획득");
    }

    // <비활성화>
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃 했습니다.");
    }

    // 해체
    // 5. OnDestroy() -> 게임 오브젝트가 삭제될 때 (무언가를 남기고 삭제된다는 의미)
    void onDestroy()
    {
        Debug.Log("플레이어 데이터 해체");
    }
}
