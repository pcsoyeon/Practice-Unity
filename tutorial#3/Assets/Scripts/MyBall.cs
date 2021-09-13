using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    // Transform 과 비교했을 시, RigidBody를 사용한 이동이 좀 더 자연스러움 (공을 움직일 때)
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // Unity의 component를 변수로 갖고 옴 -> script 내에서 설정 가능
        // #1 속력 바꾸기
        // velocity: 물체의 현재 속도 
        //rigid.velocity = Vector3.right; // 오른쪽으로 이동
        //rigid.velocity = new Vector3(2, 4, 3); // custom 속력

        // AddForce(vec): vec의 방향과 크기로 힘을 줌
        // ForeMode: 힘을 주는 방식(가속, 무게 반영) - 보통 Impluse 많이 사용(Impulse는 Component의 Mass 영향을 받아 Mass값이 작을 수록 크게 작용)
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse); 
    }

    // RigidBody 관련 코드는 FixedUpdate에 작성 (-> Unity 권장)
    void FixedUpdate()
    {
        // #2 힘을 가하기 
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        //}

        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //rigid.AddForce(vec, ForceMode.Impulse);

        // #3 회전력
        // 이동 방향을 축으로 해서 회전 (ex, .up으로 하면 z축을 기준으로 빙글빙글 돌게 됨)
        //rigid.AddTorque(Vector3.back);

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    // cube 안에 머물러 있을 때
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
