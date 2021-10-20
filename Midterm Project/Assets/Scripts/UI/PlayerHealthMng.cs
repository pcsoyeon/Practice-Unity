using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthMng : MonoBehaviour
{
    public GameObject gameOver;

    public int endScore = 0;
    int count = 10;
    Text countText;

    void Start()
    {
        countText = GetComponent<Text>();
        countText.text = "Player HP: " + count;
    }

    public void SubtractHealth(int sub)
    {
        count -= sub;
        countText.text = "Player HP: " + count;

        if (count <= endScore)
        {
            gameOver.SetActive(true);
        }
    }

    public void AddHealth(int add)
    {
        count += add;
        countText.text = "Player HP: " + count;
    }
}
