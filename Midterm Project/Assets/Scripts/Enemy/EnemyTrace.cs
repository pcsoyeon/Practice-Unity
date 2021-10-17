using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTrace : MonoBehaviour
{
    public Transform playerTr;
    NavMeshAgent agent;

    public float shortInterval = 1;
    float shotTime = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {

        shotTime += Time.deltaTime;

        if (shotTime > shortInterval)
        {
            Move(playerTr.position);

            shotTime = 0;
        }

        
    }

    void Move(Vector3 pos)
    {
        if (agent.isPathStale == false)
        {
            agent.destination = pos;
            agent.isStopped = false;
        }
    }
}