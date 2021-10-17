using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public AudioClip fireAC;

    ParticleSystem muzzleFlash;
    AudioSource ads;

    void Start()
    { 
        muzzleFlash = firePos.GetComponentInChildren<ParticleSystem>();

        ads = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject obj = Instantiate(bullet, firePos.position, firePos.rotation);
        Destroy(obj, 3);

        muzzleFlash.Play();

        ads.PlayOneShot(fireAC); 
    }
}
