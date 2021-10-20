using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : MonoBehaviour
{
    public Transform playerTr; 
    public Transform[] wayPoints; 
    public GameObject bullet;

    public float shotInterval = 1.0f;
    float shotTime = 0.0f;

    public float deltaTime = 0.0f;

    int nextIndex = 0;

    NavMeshAgent agent;
    Renderer render;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        render = GetComponent<Renderer>();

        wayPoints[0] = GameObject.Find("Pos1").GetComponent<Transform>();
        wayPoints[1] = GameObject.Find("Pos2").GetComponent<Transform>();
        wayPoints[2] = GameObject.Find("Pos3").GetComponent<Transform>();
        wayPoints[3] = GameObject.Find("Pos4").GetComponent<Transform>();
    }

    void Update()
    {
        shotTime += Time.deltaTime;
        shotInterval = Random.Range(2, 5);

        if (shotTime > shotInterval)
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Attack(wayPoints[nextIndex].position);
            shotTime = 0;
        }

        deltaTime += Time.deltaTime;
        if (deltaTime <= 1.0f)
        {
            Move(playerTr.position);
        } else if (deltaTime <= 3.0f)
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Move(wayPoints[nextIndex].position);
        } else
        {
            deltaTime = 0.0f;
        }
    } 

    void Attack(Vector3 fireDir)
    {
        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody>().AddForce(fireDir * 100);

        Destroy(obj, 10);
    }

    void Move(Vector3 nextPos)
    {
        if (agent.isPathStale == false)
        {
            agent.destination = nextPos;
            agent.isStopped = false;
        }
    }

    void OnDisable()
    {
        agent.enabled = false;
        GetComponent<Renderer>().material.color = Color.gray;

        Destroy(this.gameObject, 3);
    }
}

