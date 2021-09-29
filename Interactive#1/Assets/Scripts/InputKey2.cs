using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space 눌렀음");
        }

        if(Input.GetKeyUp("space"))
        {
            print("space 떼었음");
        }
    }
}
