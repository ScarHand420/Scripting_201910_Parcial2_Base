using UnityEngine;

public class Attack : Task
{
    [SerializeField]
    private GameObject player;

    private void Update()
    {
        transform.LookAt(player.transform);
    }
    public override bool Execute()
    {
        if (GetComponent<AICharacter>().HP > 0)
        {
            GetComponent<AICharacter>().SpawnBullet2();
            return true;
        }
        else
        {
            return false;
        }
    }
}