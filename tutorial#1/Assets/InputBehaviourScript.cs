using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // anyKey: 아무 입력을 받으면 true
        //if (Input.anyKey)
        //{
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        //}

        // Input: 사용자의 입력값을 받음 
        if (Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }


        // 각 입력 함수는 3가지 행동으로 구분
        // GetKey: 키보드 버튼 입력을 받으면 true
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중 ");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");


        // GetMouse: 마우스 버튼 입력을 받으면 true
        // 매개변수를 숫자로 받음 -> 0/1: 0이 왼쪽 버튼/1이 오른쪽 버튼
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("미사일 발사!");
        }

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");


        // Edit -> Project Settings -> Input 에서 입력값 custom 가능
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        // Input 의 size 늘려서 custom 버튼 입력 추가
        if (Input.GetButtonDown("SuperFire"))
            Debug.Log("필살기!");

        if (Input.GetButton("SuperFire"))
            Debug.Log("필살기 모으는 중...");

        if (Input.GetButtonUp("SuperFire"))
            Debug.Log("필살기!!");
    }
}
