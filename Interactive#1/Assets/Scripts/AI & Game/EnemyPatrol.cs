using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] wayPoints; // 순찰 지점 위치 리스트

    int nextIndex = 0; // 다음 순찰지점 인덱스 
    NavMeshAgent agent; // NavMeshAgent Component 변수 

    void Start()
    {
        // NavMeshAgent Component 가져오기
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // agent가 목적지에 도착했는지 검사
        if (agent.remainingDistance < 1.0f && agent.velocity.magnitude < 0.5f)
        {
            nextIndex = Random.Range(0, wayPoints.Length);
            Move(wayPoints[nextIndex].position);
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
