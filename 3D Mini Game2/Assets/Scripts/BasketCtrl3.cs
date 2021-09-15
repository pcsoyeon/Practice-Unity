using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketCtrl3 : MonoBehaviour
{
    public AudioClip correctSnd;
    public AudioClip wrongSnd;
    AudioSource ads;

    public Text scoreText;
    public Text chanceText;
    public GameObject gameOver;

    int score = 0;
    int chance = 3;

    void Start()
    {
        ads = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -1)
            {
                transform.Translate(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 1)
            {
                transform.Translate(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.z < 1)
            {
                transform.Translate(0, 0, 1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.z > -1)
            {
                transform.Translate(0, 0, -1);
            }
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Apple")
        {
            ads.PlayOneShot(correctSnd);
            Destroy(coll.gameObject);

            score += 10;
            scoreText.text = "점수 " + score;
        }
        else if (coll.gameObject.tag == "Bomb")
        {
            ads.PlayOneShot(wrongSnd);
            Destroy(coll.gameObject);

            --chance;
            chanceText.text = "기회 " + chance;

            if (chance <= 0)
            {
                gameOver.SetActive(true);
                Destroy(gameObject, 1); // 0으로 설정하면 충돌 후 audio 실행 x 
            }
        }
    }
}
