using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthMng : MonoBehaviour
{
    public int endScore = 1;

    int count = 3;
    Text countText;

    void Start()
    {
        countText = GetComponent<Text>();
        countText.text = "Enemy HP: " + count;
    }

    public void SubtractHealth(int sub)
    {
        count -= sub;
        countText.text = "Enemy HP: " + count;

        if (count <= 0) {
            count = 4;
        }
    }
}
