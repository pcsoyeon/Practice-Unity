using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            print("left");
        }

        if (Input.GetKey("right"))
        {
            print("right");
        }

        if (Input.GetKey("up"))
        {
            print("up");
        }

        if (Input.GetKey("down"))
        {
            print("down");
        }
    }
}
