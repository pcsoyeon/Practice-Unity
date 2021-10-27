using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl2 : MonoBehaviour
{
    public Transform playerTr; 
    public Transform[] wayPoints; 
    public GameObject bullet;

    public float shotInterval = 3.0f;
    float shotTime = 0;

    public float traceInterval = 1.0f;
    float traceTime = 0;

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
        if (shotTime >= 3.0f)
        {
            Attack();
            shotTime = 0;
        }

        traceTime += Time.deltaTime;
        if (traceTime > traceInterval)
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Move(wayPoints[nextIndex].position);
            traceTime = 0;
        } 

        
    }

    void Attack()
    {
        Vector3 fireDir = (playerTr.position - transform.position).normalized;

        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody>().AddForce(fireDir * 200);

        Destroy(obj, 5);
    }

    void Move(Vector3 pos)
    {
        if (agent.isPathStale == false)
        {
            agent.destination = pos;
            agent.isStopped = false;
        }
    }


    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("ENHANCE"))
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Move(wayPoints[nextIndex].position);
        }

        if (coll.collider.CompareTag("RECOVER"))
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Move(wayPoints[nextIndex].position);
        }

        if (coll.collider.CompareTag("ENEMY") || coll.collider.CompareTag("TANK"))
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Move(wayPoints[nextIndex].position);
        }
    }

    void OnDisable()
    {
        agent.enabled = false;
        GetComponent<Renderer>().material.color = Color.gray; 

        Destroy(this.gameObject, 3);
    }
}

