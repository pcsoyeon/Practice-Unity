using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCtrl2 : MonoBehaviour
{
    public AudioClip correctSnd;
    public AudioClip wrongSnd;
    AudioSource ads;

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
        }
        else if (coll.gameObject.tag == "Bomb")
        {
            ads.PlayOneShot(wrongSnd);
            Destroy(coll.gameObject);
        }
    }
}
