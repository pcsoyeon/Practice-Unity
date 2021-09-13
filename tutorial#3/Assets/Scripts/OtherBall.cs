using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // 충돌 했을 때
    // Collision: 충돌 정보 서비스 
    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.name) == "My Ball")
            mat.color = new Color(0, 0, 0);

    }

    // 충돌 중
    private void OnCollisionStay(Collision collision)
    {
        
    }

    // 충돌이 끝났을 때
    private void OnCollisionExit(Collision collision)
    {
        if ((collision.gameObject.name) == "My Ball")
            mat.color = new Color(1, 1, 1);

    }
}
