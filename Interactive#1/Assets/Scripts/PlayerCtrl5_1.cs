using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl5_1 : MonoBehaviour
{
    public float force = 300;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 수직 속력을 검사해서 연속 점프 막기
        // Mathf 클래스 -> float에 관한 수학 함수 -> 그 중 Abs (absolute = 절대값) -> 강체의 수직 속력의 절대값이 0에 근접하면 space를 눌러서 점프 허용
        // = -0.001f < 수직 속력의 절대값 < 0.001f 일 때만 점프 가능 = 0에 근접할 때만 점프 가능 = 연속 불가 
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            if (Input.GetKeyDown("space"))
            {
                // 위로 힘을 가함 -> 점프 
                rb.AddForce(0, force, 0);
            }
        }
        
    }
}
