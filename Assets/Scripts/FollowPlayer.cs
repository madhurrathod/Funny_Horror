using UnityEngine;
using UnityEngine.AI;


public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
}
