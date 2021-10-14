using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject expEffect;
    public AudioClip expSound;
    public int deathNum = 5;

    int hitCount = 0;
    AudioSource ads;

    void Start()
    {
        ads = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BULLET2"))
        {
            if (++hitCount == deathNum) // 발사체에 10회 맞았다면 
            {
                GetComponent<PlayerCtrl6>().enabled = false;
                GetComponentInChildren<FireCtrl3>().enabled = false;
                ExpPlayer();
            }
        }
    }

    void ExpPlayer()
    {
        GameObject effect = Instantiate(expEffect);
        effect.transform.position = transform.position;
        Destroy(effect, 2.0f);
        ads.PlayOneShot(expSound);
    }
}
