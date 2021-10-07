using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FollowPlayer : MonoBehaviour
{
    private NavMeshAgent agent;
    Transform player = null;

    private void Awake()
    {
        if (GetComponent<NavMeshAgent>() != null)
            agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player = other.transform;
        }
    }

    private void Update()
    {
        if (player == null) return;

        agent.SetDestination(player.position);
    }
}
