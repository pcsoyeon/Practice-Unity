using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyKillMng : MonoBehaviour
{
    public GameObject gameClear;
    public int endScore = 10;
    int count = 0;
    Text countText;

    void Start()
    {
        countText = GetComponent<Text>();
    }

    public void AddScore(int add)
    {
        count += add;
        countText.text = "Enemy Kill : " + count;

        if (count >= endScore)
        {
            gameClear.SetActive(true);
        }
    }
}
