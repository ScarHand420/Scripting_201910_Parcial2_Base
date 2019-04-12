using UnityEngine;
using UnityEngine.AI;

public class MoveToDistance : Task
{
    [SerializeField]
    private GameObject player;

    private NavMeshAgent nav;

    private float distance;

    private bool canMove;

    private void Start()
    {
        nav = GetComponentInParent<NavMeshAgent>();
    }

    private void Update()
    {
        //Debug.Log(testBool);

        distance = Vector3.Distance(player.transform.position, transform.position);

        //Debug.Log(distance);

        //if (distance > 10f && distance < 25f && canMove)
        //{
        //    nav.SetDestination(player.transform.position);

        //    //if (distance <= 10)
        //    //{
        //    //    nav.ResetPath();
        //    //    canMove = false;
        //    //}
        //}
        //else
        //{
        //    nav.ResetPath();
        //}

        //else
        //{
        //    canMove = false;
        //}
        //else
        //{
        //    //nav.ResetPath();
        //    //Execute();
        //}
    }

    public override bool Execute()
    {
        //canMove = true;

        nav.SetDestination(player.transform.position);

        //if (distance > 10f && distance < 25f && canMove)
        //{
        //    nav.SetDestination(player.transform.position);

        //    if (distance <= 10)
        //    {
        //        nav.ResetPath();
        //        canMove = false;
        //    }
        //}
        //else
        //{
        //    nav.ResetPath();
        //}

        return true;

        //if (distance > 10f && distance < 25f)
        //{
        //    canMove = true;
        //    return false;
        //}
        //else
        //{
        //    //testBool = false;
        //    return true;
        //}
    }
}