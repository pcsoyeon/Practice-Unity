using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] wayPoints; 

    int nextIndex = 0; 
    NavMeshAgent agent;

    public float shortInterval = 2;
    float shotTime = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (agent.remainingDistance < 1.0f && agent.velocity.magnitude < 0.5f)
        {
            nextIndex = Random.Range(0, wayPoints.Length);

            shotTime += Time.deltaTime;

            if (shotTime > shortInterval)
            {
                Move(wayPoints[nextIndex].position);

                shotTime = 0;
            }
            
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
