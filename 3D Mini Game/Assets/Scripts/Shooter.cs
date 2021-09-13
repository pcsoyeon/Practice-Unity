using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public AudioClip sound;

    Vector3 beginPos;
    AudioSource ads;

    void Start()
    {
        ads = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            beginPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ads.PlayOneShot(sound);

            Vector3 delta = Input.mousePosition - beginPos;
            Vector3 force = new Vector3(delta.x, delta.y, Mathf.Abs(delta.y));

            GameObject obj = Instantiate(bullet);
            obj.GetComponent<Rigidbody>().AddForce(force * 5);
        }
    }
}
