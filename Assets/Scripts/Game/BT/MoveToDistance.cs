using UnityEngine;
using UnityEngine.AI;

public class MoveToDistance : Task
{
    [SerializeField]
    private GameObject player;

    private NavMeshAgent nav;

    private float distance;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);

        //Debug.Log(distance);
    }

    public override bool Execute()
    {
        if (distance > 10f)
        {
            nav.SetDestination(player.transform.position);
            return false;
        }
        else
        {
            return true;
        }
    }
}