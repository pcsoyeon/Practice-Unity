using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCtrl3 : MonoBehaviour
{
    public GameObject expEffect;
    public AudioClip expSound;

    int hitCount = 0; // 발사체에 맞은 횟수 
    Rigidbody rb;

    AudioSource ads;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ads = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BULLET"))
        {
            if (++hitCount == 3) // 발사체에 3회 맞았다면 
            {
                ExpBarrel(collision);
            }
        }
    }

    void ExpBarrel(Collision coll)
    {
        rb.AddForce(0, 10000, 0); // 위로 힘을 가함

        GameObject effect = Instantiate(expEffect);
        effect.transform.position = coll.transform.position;
        Destroy(effect, 2);

        GetComponent<Renderer>().material.color = Color.gray;

        ads.PlayOneShot(expSound);
    }
}
