using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : MonoBehaviour
{
    public Transform playerTr; // 주인공 위치 
    public Transform[] wayPoints; // 순찰지점 위치 리스트 
    public GameObject bullet; // 총알 프리팹 

    public float traceDist = 15;
    public float attackDist = 10;
    public float shotInterval = 1;

    int nextIndex = 0;
    float shotTime = 1; // 발사 경과 시간 (바로 발사 가능)

    NavMeshAgent agent; 
    Renderer render;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        // 적의 위치와 플레이어의 위치
        // magnitude -> 거리 의미 
        float dist = (playerTr.position - transform.position).magnitude;

        if (dist < attackDist)
        {
            shotTime += Time.deltaTime;
            if (shotTime > shotInterval)
            {
                Attack(); // 주인공 공격 
                shotTime = 0;
            }
            render.material.color = Color.red;
        }
        else if (dist < traceDist)
        {
            Move(playerTr.position); // 플레이어 위치로 이동 
            render.material.color = Color.yellow; // 색상 변경 
        }
        else
        {
            if (agent.remainingDistance < 1.0f && agent.velocity.magnitude < 0.5f)
            {
                nextIndex = Random.Range(0, wayPoints.Length);
                Move(wayPoints[nextIndex].position);
            }
            render.material.color = Color.yellow * 0.7f;
        }
    }

    void Attack()
    {
        // 사격 방향 계산
        // 목표지점 - 시작지점 (순서 지킬 것)
        Vector3 fireDir = (playerTr.position - transform.position).normalized;

        // 총알 프리팹 생성
        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody>().AddForce(fireDir * 100);

        // 5초 후 자동 소멸 
        Destroy(obj, 5);
    }

    void Move(Vector3 nextPos)
    {
        if (agent.isPathStale == false)
        {
            agent.destination = nextPos;
            agent.isStopped = false;
        }
    }

    // 오브젝트 비활성화 시에 실행
    // 1. 길 찾기 기능 끄기
    // 2. 검은색으로 변경
    // 3. 위로 이동 
    void OnDisable()
    {
        agent.enabled = false; // 에이전트 비활성화 
        GetComponent<Renderer>().material.color = Color.black; // 색상 black으로 수정 
        GetComponent<Rigidbody>().velocity = Vector3.zero; // 속도 초기화 -> 위로 제대로 폭발하기 위해 
        GetComponent<Rigidbody>().AddForce(0, 3000, 0); // 위로 솟구치는 힘을 가함 
    }
}
