using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Transform tr; // 이미 있으므로 굳이 만들 필요 없음

    }

    // Update is called once per frame
    void Update()
    {
        // Update는 1초에 50-60번씩 호출되므로 계속 위치 변화 
        Vector3 vector3 = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vector3);
    }
}
