using UnityEngine;

public class AICharacter : Character
{
    [SerializeField]
    private State[] states;

    [SerializeField]
    private State currentState;

    private bool warning;

    private bool act;

    private bool idle;

    private float distance;

    [SerializeField]
    private GameObject player;

    public bool Warning { get => warning; set => warning = value; }
    public bool Act { get => act; set => act = value; }
    public bool Idle { get => idle; set => idle = value; }
    public float Distance { get => distance; set => distance = value; }

    public void SetNewState(State newState)
    {
        currentState = newState;
        currentState.Execute();
    }

    //public void SpawnBulletAI()
    //{
    //    SpawnBullet();
    //}

    private void Update()
    {
        Distance = Vector3.Distance(player.transform.position, transform.position);

        //Debug.Log(Distance);

        Debug.Log(currentState);

        if (Distance > 25)
        {
            Idle = true;
            SetNewState(states[0]);
            Warning = false;
            Act = false;
        }
        else if (Distance <= 25 && Distance > 10)
        {
            Warning = true;
            SetNewState(states[1]);
            Act = false;
            Idle = false;
        }
        else if (Distance <= 10)
        {
            Warning = false;
            SetNewState(states[2]);
            Act = true;
            Idle = false;
        }

    }
}