using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCRandomMove : MonoBehaviour
{
    private NavMeshAgent agent;
    public float moveRadius = 10f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        MoveToRandomPosition();
    }

    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            MoveToRandomPosition();
        }
    }

    void MoveToRandomPosition()
    {
        Vector3 randsomDirection = Random.insideUnitSphere * moveRadius;
        randsomDirection += transform.position;
        if(NavMesh.SamplePosition(randsomDirection, out NavMeshHit hit, moveRadius, 1))
        {
            agent.SetDestination(hit.position);
        }
    }
}
