using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    public int num;
    public float real;
    public bool fact;
    public string msg;

    // Start is called before the first frame update
    void Start()
    {
        print("num: " + num);
        print("real: " + real);
        print("fact: " + fact);
        print("msg: " + msg);
    }

    // Update is called once per frame
    void Update()
    {
        //print("매 프레임 실행");
    }
}
