using UnityEngine;
using UnityEngine.AI;
using System;
using System.Collections;

public class DoKamikazeAttack : Task
{
    public override bool Execute()
    {
        GetComponentInParent<NavMeshAgent>().speed = 30;

        StartCoroutine(Kamikaze());

        return true;
    }

    IEnumerator Kamikaze()
    {
        yield return new WaitForSeconds(4);

        //daño al jugador

        Destroy(gameObject.transform.parent.gameObject);
    }
}