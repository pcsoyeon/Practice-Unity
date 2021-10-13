using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTrace : MonoBehaviour
{
    public Transform playerTr;
    NavMeshAgent agent;

    void Start()
    {
        // NavMeshAgent Component 가져오기
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // 주인공 추적 
        Move(playerTr.position);
    }

    void Move(Vector3 pos) // 목표 위치까지 이동
    {
        if (agent.isPathStale == false) // 현재 경로가 유효한지 검사 
        {
            agent.destination = pos; // 다음 목적지를 pos로 지정
            agent.isStopped = false; // 이동 시작 
        }
    }
}
