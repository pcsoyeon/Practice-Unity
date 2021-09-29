using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse2 : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            print("마우스 좌측 버튼 눌렀음");
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("마우스 좌측 버튼 떼었음");
        }
    }
}
