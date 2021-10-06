using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgent : MonoBehaviour
{
    public Transform desTr;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // 유효한 경우일 때만 
        if (agent.isPathStale == false)
        {
            agent.destination = desTr.position;
        }
    }
}
