using UnityEngine;

public class Attack : Task
{
    [SerializeField]
    private GameObject player;

    
    public override bool Execute()
    {
        //if (GetComponent<AICharacter>().HP > 0)
        //{
        //    GetComponent<AICharacter>().SpawnBullet2();
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}

        GetComponentInParent<AICharacter>().SpawnBullet();

        return true;
    }

    //private void Update()
    //{
    //    Execute();
    //}
}