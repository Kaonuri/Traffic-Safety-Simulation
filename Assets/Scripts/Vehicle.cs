using SWS;
using UnityEngine;
using UnityEngine.AI;

public class Vehicle : MonoBehaviour
{
    public navMove navMove { private set; get; }
    public NavMeshAgent navMeshAgent { private set; get; }

    private void Awake()
    {
        navMove = GetComponent<navMove>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
}
