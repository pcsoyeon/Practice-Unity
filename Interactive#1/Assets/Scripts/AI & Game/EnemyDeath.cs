using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject expEffect;
    public AudioClip expSound;
    public int deathNum = 3;

    int hitCount = 0;
    AudioSource ads;

    void Start()
    {
        ads = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BULLET"))
        {
            if (++hitCount == deathNum) // 발사체에 3회 맞았다면 
            {
                GetComponent<EnemyCtrl>().enabled = false;
                ExpEnemy(collision);
            }
        }
    }

    void ExpEnemy(Collision collision)
    {
        GameObject effect = Instantiate(expEffect);
        effect.transform.position = transform.position;
        Destroy(effect, 2.0f);
        ads.PlayOneShot(expSound);
    }
}
